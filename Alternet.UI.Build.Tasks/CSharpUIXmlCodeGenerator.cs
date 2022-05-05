﻿using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Alternet.UI.Build.Tasks
{
    static class CSharpUIXmlCodeGenerator
    {
        public static string Generate(UIXmlDocument document)
        {
            var codeWriter = new StringWriter();
            var w = new IndentedTextWriter(codeWriter);

            WriteHeader(w);

            w.WriteLine(@"
using System;
");
            w.WriteLine($"namespace {document.ClassNamespaceName}");

            using (new BlockIndent(w))
            {
                w.WriteLine($"partial class {document.ClassName} : {document.BaseClassFullName}");
                using (new BlockIndent(w))
                {
                    var namedObjects = document.NamedObjects;
                    foreach (var namedObject in namedObjects)
                        w.WriteLine($"private {namedObject.TypeFullName} {namedObject.Name};");

                    w.WriteLine();
                    w.WriteLine("private bool contentLoaded;");
                    w.WriteLine();
                    w.WriteLine("[System.Diagnostics.DebuggerNonUserCodeAttribute()]");
                    w.WriteLine("public void InitializeComponent()");
                    using (new BlockIndent(w))
                    {
                        w.WriteLine("if (contentLoaded)");
                        using (new LineIndent(w))
                            w.WriteLine("return;");
                        w.WriteLine("contentLoaded = true;");

                        w.WriteLine($"var uixmlStream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream(\"{document.ResourceName}\");");
                        w.WriteLine("if (uixmlStream == null)");
                        using (new LineIndent(w))
                            w.WriteLine("throw new InvalidOperationException();");
                        w.WriteLine("new Alternet.UI.UixmlLoader().LoadExisting(uixmlStream, this);");

                        w.WriteLine();
                        foreach (var namedObject in namedObjects)
                            w.WriteLine($"{namedObject.Name} = ({namedObject.TypeFullName})FindElement(\"{namedObject.Name}\");");

                        w.WriteLine();
                        foreach (var eventBinding in document.EventBindings)
                            WriteEventBinding(w, eventBinding);
                    }
                }
            }

            return codeWriter.ToString();
        }

        private static void WriteEventBinding(IndentedTextWriter w, UIXmlDocument.EventBinding eventBinding)
        {
            switch (eventBinding)
            {
                case UIXmlDocument.NamedObjectEventBinding x:
                    w.WriteLine($"{x.ObjectName}.{x.EventName} += {x.HandlerName};");
                    break;
                case UIXmlDocument.IndexedObjectEventBinding x:
                    w.WriteLine($"{GetIndexedObjectRetreivalExpression(x.ObjectTypeFullName, x.ObjectIndices)}.{x.EventName} += {x.HandlerName};");
                    break;
                default:
                    throw new InvalidOperationException();
            }
        }

        private static string GetIndexedObjectRetreivalExpression(string objectTypeFullName, IReadOnlyList<int> objectIndices)
        {
            var result = new StringBuilder();
            result.Append($"(({objectTypeFullName})(");
            
            if (objectIndices.Count == 0)
                throw new InvalidOperationException();

            for (int i = 0; i < objectIndices.Count; i++)
            {
                int index = objectIndices[i];
                if (i > 0)
                    result.Append(".");
                result.Append($"Children[{index}]");
            }

            result.Append("))");
            return result.ToString();
        }

        private static void WriteHeader(IndentedTextWriter w)
        {
            w.WriteLine("//------------------------------------------------------------------------------");
            w.WriteLine("// <auto-generated>");
            w.WriteLine("//     This code was generated by a tool.");
            w.WriteLine("//     Changes to this file may cause incorrect behavior and will be lost if");
            w.WriteLine("//     the code is regenerated.");
            w.WriteLine("// </auto-generated>");
            w.WriteLine("//------------------------------------------------------------------------------");
            w.WriteLine();
        }
    }
}
