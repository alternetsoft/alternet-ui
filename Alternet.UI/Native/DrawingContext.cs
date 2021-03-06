// <auto-generated>This code was generated by a tool, DO NOT MODIFY MANUALLY. Copyright AlterNET, 2022.</auto-generated>
#nullable enable

using System;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Security;
namespace Alternet.UI.Native
{
    internal class DrawingContext : NativeObject
    {
        static DrawingContext()
        {
        }
        
        private DrawingContext()
        {
        }
        
        public DrawingContext(IntPtr nativePointer) : base(nativePointer)
        {
        }
        
        public static DrawingContext FromImage(Image image)
        {
            var n = NativeApi.DrawingContext_FromImage_(image.NativePointer);
            var m = NativeObject.GetFromNativePointer<DrawingContext>(n, p => new DrawingContext(p))!;
            ReleaseNativeObjectPointer(n);
            return m;
        }
        
        public void FillRectangle(Alternet.Drawing.Rect rectangle, Brush brush)
        {
            CheckDisposed();
            NativeApi.DrawingContext_FillRectangle_(NativePointer, rectangle, brush.NativePointer);
        }
        
        public void DrawRectangle(Alternet.Drawing.Rect rectangle, Pen pen)
        {
            CheckDisposed();
            NativeApi.DrawingContext_DrawRectangle_(NativePointer, rectangle, pen.NativePointer);
        }
        
        public void FillEllipse(Alternet.Drawing.Rect bounds, Brush brush)
        {
            CheckDisposed();
            NativeApi.DrawingContext_FillEllipse_(NativePointer, bounds, brush.NativePointer);
        }
        
        public void DrawEllipse(Alternet.Drawing.Rect bounds, Pen pen)
        {
            CheckDisposed();
            NativeApi.DrawingContext_DrawEllipse_(NativePointer, bounds, pen.NativePointer);
        }
        
        public void FloodFill(Alternet.Drawing.Point point, Brush brush)
        {
            CheckDisposed();
            NativeApi.DrawingContext_FloodFill_(NativePointer, point, brush.NativePointer);
        }
        
        public void DrawText(string text, Alternet.Drawing.Point origin, Font font, Brush brush)
        {
            CheckDisposed();
            NativeApi.DrawingContext_DrawText_(NativePointer, text, origin, font.NativePointer, brush.NativePointer);
        }
        
        public void DrawImageAtPoint(Image image, Alternet.Drawing.Point origin)
        {
            CheckDisposed();
            NativeApi.DrawingContext_DrawImageAtPoint_(NativePointer, image.NativePointer, origin);
        }
        
        public void DrawImageAtRect(Image image, Alternet.Drawing.Rect rect)
        {
            CheckDisposed();
            NativeApi.DrawingContext_DrawImageAtRect_(NativePointer, image.NativePointer, rect);
        }
        
        public Alternet.Drawing.Size MeasureText(string text, Font font)
        {
            CheckDisposed();
            var n = NativeApi.DrawingContext_MeasureText_(NativePointer, text, font.NativePointer);
            var m = n;
            return m;
        }
        
        public void PushTransform(Alternet.Drawing.Size translation)
        {
            CheckDisposed();
            NativeApi.DrawingContext_PushTransform_(NativePointer, translation);
        }
        
        public void Pop()
        {
            CheckDisposed();
            NativeApi.DrawingContext_Pop_(NativePointer);
        }
        
        public void DrawLine(Alternet.Drawing.Point a, Alternet.Drawing.Point b, Pen pen)
        {
            CheckDisposed();
            NativeApi.DrawingContext_DrawLine_(NativePointer, a, b, pen.NativePointer);
        }
        
        public void DrawLines(Alternet.Drawing.Point[] points, Pen pen)
        {
            CheckDisposed();
            NativeApi.DrawingContext_DrawLines_(NativePointer, Array.ConvertAll<Alternet.Drawing.Point, NativeApiTypes.Point>(points, x => x), points.Length, pen.NativePointer);
        }
        
        
        [SuppressUnmanagedCodeSecurity]
        private class NativeApi : NativeApiProvider
        {
            static NativeApi() => Initialize();
            
            [DllImport(NativeModuleName, CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr DrawingContext_FromImage_(IntPtr image);
            
            [DllImport(NativeModuleName, CallingConvention = CallingConvention.Cdecl)]
            public static extern void DrawingContext_FillRectangle_(IntPtr obj, NativeApiTypes.Rect rectangle, IntPtr brush);
            
            [DllImport(NativeModuleName, CallingConvention = CallingConvention.Cdecl)]
            public static extern void DrawingContext_DrawRectangle_(IntPtr obj, NativeApiTypes.Rect rectangle, IntPtr pen);
            
            [DllImport(NativeModuleName, CallingConvention = CallingConvention.Cdecl)]
            public static extern void DrawingContext_FillEllipse_(IntPtr obj, NativeApiTypes.Rect bounds, IntPtr brush);
            
            [DllImport(NativeModuleName, CallingConvention = CallingConvention.Cdecl)]
            public static extern void DrawingContext_DrawEllipse_(IntPtr obj, NativeApiTypes.Rect bounds, IntPtr pen);
            
            [DllImport(NativeModuleName, CallingConvention = CallingConvention.Cdecl)]
            public static extern void DrawingContext_FloodFill_(IntPtr obj, NativeApiTypes.Point point, IntPtr brush);
            
            [DllImport(NativeModuleName, CallingConvention = CallingConvention.Cdecl)]
            public static extern void DrawingContext_DrawText_(IntPtr obj, string text, NativeApiTypes.Point origin, IntPtr font, IntPtr brush);
            
            [DllImport(NativeModuleName, CallingConvention = CallingConvention.Cdecl)]
            public static extern void DrawingContext_DrawImageAtPoint_(IntPtr obj, IntPtr image, NativeApiTypes.Point origin);
            
            [DllImport(NativeModuleName, CallingConvention = CallingConvention.Cdecl)]
            public static extern void DrawingContext_DrawImageAtRect_(IntPtr obj, IntPtr image, NativeApiTypes.Rect rect);
            
            [DllImport(NativeModuleName, CallingConvention = CallingConvention.Cdecl)]
            public static extern NativeApiTypes.Size DrawingContext_MeasureText_(IntPtr obj, string text, IntPtr font);
            
            [DllImport(NativeModuleName, CallingConvention = CallingConvention.Cdecl)]
            public static extern void DrawingContext_PushTransform_(IntPtr obj, NativeApiTypes.Size translation);
            
            [DllImport(NativeModuleName, CallingConvention = CallingConvention.Cdecl)]
            public static extern void DrawingContext_Pop_(IntPtr obj);
            
            [DllImport(NativeModuleName, CallingConvention = CallingConvention.Cdecl)]
            public static extern void DrawingContext_DrawLine_(IntPtr obj, NativeApiTypes.Point a, NativeApiTypes.Point b, IntPtr pen);
            
            [DllImport(NativeModuleName, CallingConvention = CallingConvention.Cdecl)]
            public static extern void DrawingContext_DrawLines_(IntPtr obj, NativeApiTypes.Point[] points, int pointsCount, IntPtr pen);
            
        }
    }
}
