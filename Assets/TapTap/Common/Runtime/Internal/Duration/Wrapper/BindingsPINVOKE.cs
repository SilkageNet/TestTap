//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------
using System.Runtime.InteropServices;

namespace com.taptap.tapsdk.bindings.csharp {

class BindingsPINVOKE {

  protected class SWIGExceptionHelper {

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void ExceptionDelegate(string message);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void ExceptionArgumentDelegate(string message, string paramName);

    static ExceptionDelegate applicationDelegate = new ExceptionDelegate(SetPendingApplicationException);
    static ExceptionDelegate arithmeticDelegate = new ExceptionDelegate(SetPendingArithmeticException);
    static ExceptionDelegate divideByZeroDelegate = new ExceptionDelegate(SetPendingDivideByZeroException);
    static ExceptionDelegate indexOutOfRangeDelegate = new ExceptionDelegate(SetPendingIndexOutOfRangeException);
    static ExceptionDelegate invalidCastDelegate = new ExceptionDelegate(SetPendingInvalidCastException);
    static ExceptionDelegate invalidOperationDelegate = new ExceptionDelegate(SetPendingInvalidOperationException);
    static ExceptionDelegate ioDelegate = new ExceptionDelegate(SetPendingIOException);
    static ExceptionDelegate nullReferenceDelegate = new ExceptionDelegate(SetPendingNullReferenceException);
    static ExceptionDelegate outOfMemoryDelegate = new ExceptionDelegate(SetPendingOutOfMemoryException);
    static ExceptionDelegate overflowDelegate = new ExceptionDelegate(SetPendingOverflowException);
    static ExceptionDelegate systemDelegate = new ExceptionDelegate(SetPendingSystemException);

    static ExceptionArgumentDelegate argumentDelegate = new ExceptionArgumentDelegate(SetPendingArgumentException);
    static ExceptionArgumentDelegate argumentNullDelegate = new ExceptionArgumentDelegate(SetPendingArgumentNullException);
    static ExceptionArgumentDelegate argumentOutOfRangeDelegate = new ExceptionArgumentDelegate(SetPendingArgumentOutOfRangeException);

    [global::System.Runtime.InteropServices.DllImport(Bindings.DLL_NAME, EntryPoint="SWIGRegisterExceptionCallbacks_Bindings")]
    public static extern void SWIGRegisterExceptionCallbacks_Bindings(
                                ExceptionDelegate applicationDelegate,
                                ExceptionDelegate arithmeticDelegate,
                                ExceptionDelegate divideByZeroDelegate, 
                                ExceptionDelegate indexOutOfRangeDelegate, 
                                ExceptionDelegate invalidCastDelegate,
                                ExceptionDelegate invalidOperationDelegate,
                                ExceptionDelegate ioDelegate,
                                ExceptionDelegate nullReferenceDelegate,
                                ExceptionDelegate outOfMemoryDelegate, 
                                ExceptionDelegate overflowDelegate, 
                                ExceptionDelegate systemExceptionDelegate);

    [global::System.Runtime.InteropServices.DllImport(Bindings.DLL_NAME, EntryPoint="SWIGRegisterExceptionArgumentCallbacks_Bindings")]
    public static extern void SWIGRegisterExceptionCallbacksArgument_Bindings(
                                ExceptionArgumentDelegate argumentDelegate,
                                ExceptionArgumentDelegate argumentNullDelegate,
                                ExceptionArgumentDelegate argumentOutOfRangeDelegate);

    [AOT.MonoPInvokeCallback(typeof(ExceptionDelegate))]
    static void SetPendingApplicationException(string message) {
      SWIGPendingException.Set(new global::System.ApplicationException(message, SWIGPendingException.Retrieve()));
    }
    [AOT.MonoPInvokeCallback(typeof(ExceptionDelegate))]
    static void SetPendingArithmeticException(string message) {
      SWIGPendingException.Set(new global::System.ArithmeticException(message, SWIGPendingException.Retrieve()));
    }
    [AOT.MonoPInvokeCallback(typeof(ExceptionDelegate))]
    static void SetPendingDivideByZeroException(string message) {
      SWIGPendingException.Set(new global::System.DivideByZeroException(message, SWIGPendingException.Retrieve()));
    }
    [AOT.MonoPInvokeCallback(typeof(ExceptionDelegate))]
    static void SetPendingIndexOutOfRangeException(string message) {
      SWIGPendingException.Set(new global::System.IndexOutOfRangeException(message, SWIGPendingException.Retrieve()));
    }
    [AOT.MonoPInvokeCallback(typeof(ExceptionDelegate))]
    static void SetPendingInvalidCastException(string message) {
      SWIGPendingException.Set(new global::System.InvalidCastException(message, SWIGPendingException.Retrieve()));
    }
    [AOT.MonoPInvokeCallback(typeof(ExceptionDelegate))]
    static void SetPendingInvalidOperationException(string message) {
      SWIGPendingException.Set(new global::System.InvalidOperationException(message, SWIGPendingException.Retrieve()));
    }
    [AOT.MonoPInvokeCallback(typeof(ExceptionDelegate))]
    static void SetPendingIOException(string message) {
      SWIGPendingException.Set(new global::System.IO.IOException(message, SWIGPendingException.Retrieve()));
    }
    [AOT.MonoPInvokeCallback(typeof(ExceptionDelegate))]
    static void SetPendingNullReferenceException(string message) {
      SWIGPendingException.Set(new global::System.NullReferenceException(message, SWIGPendingException.Retrieve()));
    }
    [AOT.MonoPInvokeCallback(typeof(ExceptionDelegate))]
    static void SetPendingOutOfMemoryException(string message) {
      SWIGPendingException.Set(new global::System.OutOfMemoryException(message, SWIGPendingException.Retrieve()));
    }
    [AOT.MonoPInvokeCallback(typeof(ExceptionDelegate))]
    static void SetPendingOverflowException(string message) {
      SWIGPendingException.Set(new global::System.OverflowException(message, SWIGPendingException.Retrieve()));
    }
    [AOT.MonoPInvokeCallback(typeof(ExceptionDelegate))]
    static void SetPendingSystemException(string message) {
      SWIGPendingException.Set(new global::System.SystemException(message, SWIGPendingException.Retrieve()));
    }
    [AOT.MonoPInvokeCallback(typeof(ExceptionArgumentDelegate))]
    static void SetPendingArgumentException(string message, string paramName) {
      SWIGPendingException.Set(new global::System.ArgumentException(message, paramName, SWIGPendingException.Retrieve()));
    }
    [AOT.MonoPInvokeCallback(typeof(ExceptionArgumentDelegate))]
    static void SetPendingArgumentNullException(string message, string paramName) {
      global::System.Exception e = SWIGPendingException.Retrieve();
      if (e != null) message = message + " Inner Exception: " + e.Message;
      SWIGPendingException.Set(new global::System.ArgumentNullException(paramName, message));
    }
    [AOT.MonoPInvokeCallback(typeof(ExceptionArgumentDelegate))]
    static void SetPendingArgumentOutOfRangeException(string message, string paramName) {
      global::System.Exception e = SWIGPendingException.Retrieve();
      if (e != null) message = message + " Inner Exception: " + e.Message;
      SWIGPendingException.Set(new global::System.ArgumentOutOfRangeException(paramName, message));
    }

    static SWIGExceptionHelper() {
      SWIGRegisterExceptionCallbacks_Bindings(
                                applicationDelegate,
                                arithmeticDelegate,
                                divideByZeroDelegate,
                                indexOutOfRangeDelegate,
                                invalidCastDelegate,
                                invalidOperationDelegate,
                                ioDelegate,
                                nullReferenceDelegate,
                                outOfMemoryDelegate,
                                overflowDelegate,
                                systemDelegate);

      SWIGRegisterExceptionCallbacksArgument_Bindings(
                                argumentDelegate,
                                argumentNullDelegate,
                                argumentOutOfRangeDelegate);
    }
  }

  protected static SWIGExceptionHelper swigExceptionHelper = new SWIGExceptionHelper();

  public class SWIGPendingException {
    [global::System.ThreadStatic]
    private static global::System.Exception pendingException = null;
    private static int numExceptionsPending = 0;
    private static global::System.Object exceptionsLock = null;

    public static bool Pending {
      get {
        bool pending = false;
        if (numExceptionsPending > 0)
          if (pendingException != null)
            pending = true;
        return pending;
      } 
    }

    public static void Set(global::System.Exception e) {
      if (pendingException != null)
        throw new global::System.ApplicationException("FATAL: An earlier pending exception from unmanaged code was missed and thus not thrown (" + pendingException.ToString() + ")", e);
      pendingException = e;
      lock(exceptionsLock) {
        numExceptionsPending++;
      }
    }

    public static global::System.Exception Retrieve() {
      global::System.Exception e = null;
      if (numExceptionsPending > 0) {
        if (pendingException != null) {
          e = pendingException;
          pendingException = null;
          lock(exceptionsLock) {
            numExceptionsPending--;
          }
        }
      }
      return e;
    }

    static SWIGPendingException() {
      exceptionsLock = new global::System.Object();
    }
  }


  protected class SWIGStringHelper {

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate string SWIGStringDelegate(string message);
    static SWIGStringDelegate stringDelegate = new SWIGStringDelegate(CreateString);

    [global::System.Runtime.InteropServices.DllImport(Bindings.DLL_NAME, EntryPoint="SWIGRegisterStringCallback_Bindings")]
    public static extern void SWIGRegisterStringCallback_Bindings(SWIGStringDelegate stringDelegate);

    [AOT.MonoPInvokeCallback(typeof(SWIGStringDelegate))]
    static string CreateString(string cString) {
      return cString;
    }

    static SWIGStringHelper() {
      SWIGRegisterStringCallback_Bindings(stringDelegate);
    }
  }

  static protected SWIGStringHelper swigStringHelper = new SWIGStringHelper();


  static BindingsPINVOKE() {
  }


  [global::System.Runtime.InteropServices.DllImport(Bindings.DLL_NAME, EntryPoint="CSharp_comftaptapftapsdkfbindingsfcsharp_DEV_TYPE_LOCAL_get___")]
  public static extern int DEV_TYPE_LOCAL_get();

  [global::System.Runtime.InteropServices.DllImport(Bindings.DLL_NAME, EntryPoint="CSharp_comftaptapftapsdkfbindingsfcsharp_DEV_TYPE_SANDBOX_get___")]
  public static extern int DEV_TYPE_SANDBOX_get();

  [global::System.Runtime.InteropServices.DllImport(Bindings.DLL_NAME, EntryPoint="CSharp_comftaptapftapsdkfbindingsfcsharp_DEV_TYPE_CLOUD_get___")]
  public static extern int DEV_TYPE_CLOUD_get();

  [global::System.Runtime.InteropServices.DllImport(Bindings.DLL_NAME, EntryPoint="CSharp_comftaptapftapsdkfbindingsfcsharp_REGION_CN_get___")]
  public static extern int REGION_CN_get();

  [global::System.Runtime.InteropServices.DllImport(Bindings.DLL_NAME, EntryPoint="CSharp_comftaptapftapsdkfbindingsfcsharp_REGION_GLOBAL_get___")]
  public static extern int REGION_GLOBAL_get();

  [global::System.Runtime.InteropServices.DllImport(Bindings.DLL_NAME, EntryPoint="CSharp_comftaptapftapsdkfbindingsfcsharp_REGION_RND_get___")]
  public static extern int REGION_RND_get();

  [global::System.Runtime.InteropServices.DllImport(Bindings.DLL_NAME, EntryPoint="CSharp_comftaptapftapsdkfbindingsfcsharp_BridgeConfig_enable_duration_statistics_set___")]
  public static extern void BridgeConfig_enable_duration_statistics_set(global::System.Runtime.InteropServices.HandleRef jarg1, bool jarg2);

  [global::System.Runtime.InteropServices.DllImport(Bindings.DLL_NAME, EntryPoint="CSharp_comftaptapftapsdkfbindingsfcsharp_BridgeConfig_enable_duration_statistics_get___")]
  public static extern bool BridgeConfig_enable_duration_statistics_get(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport(Bindings.DLL_NAME, EntryPoint="CSharp_comftaptapftapsdkfbindingsfcsharp_BridgeConfig_region_set___")]
  public static extern void BridgeConfig_region_set(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

  [global::System.Runtime.InteropServices.DllImport(Bindings.DLL_NAME, EntryPoint="CSharp_comftaptapftapsdkfbindingsfcsharp_BridgeConfig_region_get___")]
  public static extern int BridgeConfig_region_get(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport(Bindings.DLL_NAME, EntryPoint="CSharp_comftaptapftapsdkfbindingsfcsharp_BridgeConfig_device_id_set___")]
  public static extern void BridgeConfig_device_id_set(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport(Bindings.DLL_NAME, EntryPoint="CSharp_comftaptapftapsdkfbindingsfcsharp_BridgeConfig_device_id_get___")]
  public static extern string BridgeConfig_device_id_get(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport(Bindings.DLL_NAME, EntryPoint="CSharp_comftaptapftapsdkfbindingsfcsharp_BridgeConfig_cache_dir_set___")]
  public static extern void BridgeConfig_cache_dir_set(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport(Bindings.DLL_NAME, EntryPoint="CSharp_comftaptapftapsdkfbindingsfcsharp_BridgeConfig_cache_dir_get___")]
  public static extern string BridgeConfig_cache_dir_get(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport(Bindings.DLL_NAME, EntryPoint="CSharp_comftaptapftapsdkfbindingsfcsharp_BridgeConfig_ca_dir_set___")]
  public static extern void BridgeConfig_ca_dir_set(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport(Bindings.DLL_NAME, EntryPoint="CSharp_comftaptapftapsdkfbindingsfcsharp_BridgeConfig_ca_dir_get___")]
  public static extern string BridgeConfig_ca_dir_get(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport(Bindings.DLL_NAME, EntryPoint="CSharp_comftaptapftapsdkfbindingsfcsharp_BridgeConfig_device_type_set___")]
  public static extern void BridgeConfig_device_type_set(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

  [global::System.Runtime.InteropServices.DllImport(Bindings.DLL_NAME, EntryPoint="CSharp_comftaptapftapsdkfbindingsfcsharp_BridgeConfig_device_type_get___")]
  public static extern int BridgeConfig_device_type_get(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport(Bindings.DLL_NAME, EntryPoint="CSharp_comftaptapftapsdkfbindingsfcsharp_BridgeConfig_model_set___")]
  public static extern void BridgeConfig_model_set(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport(Bindings.DLL_NAME, EntryPoint="CSharp_comftaptapftapsdkfbindingsfcsharp_BridgeConfig_model_get___")]
  public static extern string BridgeConfig_model_get(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport(Bindings.DLL_NAME, EntryPoint="CSharp_comftaptapftapsdkfbindingsfcsharp_BridgeConfig_platform_set___")]
  public static extern void BridgeConfig_platform_set(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport(Bindings.DLL_NAME, EntryPoint="CSharp_comftaptapftapsdkfbindingsfcsharp_BridgeConfig_platform_get___")]
  public static extern string BridgeConfig_platform_get(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport(Bindings.DLL_NAME, EntryPoint="CSharp_comftaptapftapsdkfbindingsfcsharp_BridgeConfig_engine_set___")]
  public static extern void BridgeConfig_engine_set(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport(Bindings.DLL_NAME, EntryPoint="CSharp_comftaptapftapsdkfbindingsfcsharp_BridgeConfig_engine_get___")]
  public static extern string BridgeConfig_engine_get(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport(Bindings.DLL_NAME, EntryPoint="CSharp_comftaptapftapsdkfbindingsfcsharp_BridgeConfig_sdk_version_set___")]
  public static extern void BridgeConfig_sdk_version_set(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport(Bindings.DLL_NAME, EntryPoint="CSharp_comftaptapftapsdkfbindingsfcsharp_BridgeConfig_sdk_version_get___")]
  public static extern string BridgeConfig_sdk_version_get(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport(Bindings.DLL_NAME, EntryPoint="CSharp_comftaptapftapsdkfbindingsfcsharp_new_BridgeConfig___")]
  public static extern global::System.IntPtr new_BridgeConfig();

  [global::System.Runtime.InteropServices.DllImport(Bindings.DLL_NAME, EntryPoint="CSharp_comftaptapftapsdkfbindingsfcsharp_delete_BridgeConfig___")]
  public static extern void delete_BridgeConfig(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport(Bindings.DLL_NAME, EntryPoint="CSharp_comftaptapftapsdkfbindingsfcsharp_BridgeUser_contain_tap_info_set___")]
  public static extern void BridgeUser_contain_tap_info_set(global::System.Runtime.InteropServices.HandleRef jarg1, bool jarg2);

  [global::System.Runtime.InteropServices.DllImport(Bindings.DLL_NAME, EntryPoint="CSharp_comftaptapftapsdkfbindingsfcsharp_BridgeUser_contain_tap_info_get___")]
  public static extern bool BridgeUser_contain_tap_info_get(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport(Bindings.DLL_NAME, EntryPoint="CSharp_comftaptapftapsdkfbindingsfcsharp_BridgeUser_user_id_set___")]
  public static extern void BridgeUser_user_id_set(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport(Bindings.DLL_NAME, EntryPoint="CSharp_comftaptapftapsdkfbindingsfcsharp_BridgeUser_user_id_get___")]
  public static extern string BridgeUser_user_id_get(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport(Bindings.DLL_NAME, EntryPoint="CSharp_comftaptapftapsdkfbindingsfcsharp_new_BridgeUser___")]
  public static extern global::System.IntPtr new_BridgeUser();

  [global::System.Runtime.InteropServices.DllImport(Bindings.DLL_NAME, EntryPoint="CSharp_comftaptapftapsdkfbindingsfcsharp_delete_BridgeUser___")]
  public static extern void delete_BridgeUser(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport(Bindings.DLL_NAME, EntryPoint="CSharp_comftaptapftapsdkfbindingsfcsharp_BridgeGame_client_id_set___")]
  public static extern void BridgeGame_client_id_set(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport(Bindings.DLL_NAME, EntryPoint="CSharp_comftaptapftapsdkfbindingsfcsharp_BridgeGame_client_id_get___")]
  public static extern string BridgeGame_client_id_get(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport(Bindings.DLL_NAME, EntryPoint="CSharp_comftaptapftapsdkfbindingsfcsharp_BridgeGame_identify_set___")]
  public static extern void BridgeGame_identify_set(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport(Bindings.DLL_NAME, EntryPoint="CSharp_comftaptapftapsdkfbindingsfcsharp_BridgeGame_identify_get___")]
  public static extern string BridgeGame_identify_get(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport(Bindings.DLL_NAME, EntryPoint="CSharp_comftaptapftapsdkfbindingsfcsharp_new_BridgeGame___")]
  public static extern global::System.IntPtr new_BridgeGame();

  [global::System.Runtime.InteropServices.DllImport(Bindings.DLL_NAME, EntryPoint="CSharp_comftaptapftapsdkfbindingsfcsharp_delete_BridgeGame___")]
  public static extern void delete_BridgeGame(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport(Bindings.DLL_NAME, EntryPoint="CSharp_comftaptapftapsdkfbindingsfcsharp_InitSDK___")]
  public static extern void InitSDK(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport(Bindings.DLL_NAME, EntryPoint="CSharp_comftaptapftapsdkfbindingsfcsharp_SetCurrentGame___")]
  public static extern void SetCurrentGame(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport(Bindings.DLL_NAME, EntryPoint="CSharp_comftaptapftapsdkfbindingsfcsharp_SetCurrentUser___")]
  public static extern void SetCurrentUser(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport(Bindings.DLL_NAME, EntryPoint="CSharp_comftaptapftapsdkfbindingsfcsharp_OnWindowForeground___")]
  public static extern void OnWindowForeground();

  [global::System.Runtime.InteropServices.DllImport(Bindings.DLL_NAME, EntryPoint="CSharp_comftaptapftapsdkfbindingsfcsharp_OnWindowBackground___")]
  public static extern void OnWindowBackground();
}

}