// <auto-generated>This code was generated by a tool, DO NOT MODIFY MANUALLY. Copyright AlterNET, 2022.</auto-generated>
#nullable enable

using System;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Security;
namespace Alternet.UI.Native
{
    internal class MainMenu : Control
    {
        static MainMenu()
        {
        }
        
        public MainMenu()
        {
            SetNativePointer(NativeApi.MainMenu_Create_());
        }
        
        public MainMenu(IntPtr nativePointer) : base(nativePointer)
        {
        }
        
        public int ItemsCount
        {
            get
            {
                CheckDisposed();
                var n = NativeApi.MainMenu_GetItemsCount_(NativePointer);
                var m = n;
                return m;
            }
            
        }
        
        public void InsertItemAt(int index, Menu menu, string text)
        {
            CheckDisposed();
            NativeApi.MainMenu_InsertItemAt_(NativePointer, index, menu.NativePointer, text);
        }
        
        public void RemoveItemAt(int index)
        {
            CheckDisposed();
            NativeApi.MainMenu_RemoveItemAt_(NativePointer, index);
        }
        
        public void SetItemText(int index, string text)
        {
            CheckDisposed();
            NativeApi.MainMenu_SetItemText_(NativePointer, index, text);
        }
        
        
        [SuppressUnmanagedCodeSecurity]
        private class NativeApi : NativeApiProvider
        {
            static NativeApi() => Initialize();
            
            [DllImport(NativeModuleName, CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr MainMenu_Create_();
            
            [DllImport(NativeModuleName, CallingConvention = CallingConvention.Cdecl)]
            public static extern int MainMenu_GetItemsCount_(IntPtr obj);
            
            [DllImport(NativeModuleName, CallingConvention = CallingConvention.Cdecl)]
            public static extern void MainMenu_InsertItemAt_(IntPtr obj, int index, IntPtr menu, string text);
            
            [DllImport(NativeModuleName, CallingConvention = CallingConvention.Cdecl)]
            public static extern void MainMenu_RemoveItemAt_(IntPtr obj, int index);
            
            [DllImport(NativeModuleName, CallingConvention = CallingConvention.Cdecl)]
            public static extern void MainMenu_SetItemText_(IntPtr obj, int index, string text);
            
        }
    }
}