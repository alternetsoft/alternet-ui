// <auto-generated>This code was generated by a tool, DO NOT MODIFY MANUALLY. Copyright AlterNET, 2022.</auto-generated>
#nullable enable

using System;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Security;
namespace Alternet.UI.Native
{
    internal class ImageList : NativeObject
    {
        static ImageList()
        {
        }
        
        public ImageList()
        {
            SetNativePointer(NativeApi.ImageList_Create_());
        }
        
        public ImageList(IntPtr nativePointer) : base(nativePointer)
        {
        }
        
        public Alternet.Drawing.Int32Size PixelImageSize
        {
            get
            {
                CheckDisposed();
                var n = NativeApi.ImageList_GetPixelImageSize_(NativePointer);
                var m = n;
                return m;
            }
            
            set
            {
                CheckDisposed();
                NativeApi.ImageList_SetPixelImageSize_(NativePointer, value);
            }
        }
        
        public Alternet.Drawing.Size ImageSize
        {
            get
            {
                CheckDisposed();
                var n = NativeApi.ImageList_GetImageSize_(NativePointer);
                var m = n;
                return m;
            }
            
            set
            {
                CheckDisposed();
                NativeApi.ImageList_SetImageSize_(NativePointer, value);
            }
        }
        
        public void AddImage(Image image)
        {
            CheckDisposed();
            NativeApi.ImageList_AddImage_(NativePointer, image.NativePointer);
        }
        
        
        [SuppressUnmanagedCodeSecurity]
        private class NativeApi : NativeApiProvider
        {
            static NativeApi() => Initialize();
            
            [DllImport(NativeModuleName, CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ImageList_Create_();
            
            [DllImport(NativeModuleName, CallingConvention = CallingConvention.Cdecl)]
            public static extern NativeApiTypes.Int32Size ImageList_GetPixelImageSize_(IntPtr obj);
            
            [DllImport(NativeModuleName, CallingConvention = CallingConvention.Cdecl)]
            public static extern void ImageList_SetPixelImageSize_(IntPtr obj, NativeApiTypes.Int32Size value);
            
            [DllImport(NativeModuleName, CallingConvention = CallingConvention.Cdecl)]
            public static extern NativeApiTypes.Size ImageList_GetImageSize_(IntPtr obj);
            
            [DllImport(NativeModuleName, CallingConvention = CallingConvention.Cdecl)]
            public static extern void ImageList_SetImageSize_(IntPtr obj, NativeApiTypes.Size value);
            
            [DllImport(NativeModuleName, CallingConvention = CallingConvention.Cdecl)]
            public static extern void ImageList_AddImage_(IntPtr obj, IntPtr image);
            
        }
    }
}
