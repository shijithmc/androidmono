namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class UnsupportedAddressTypeException : java.lang.IllegalArgumentException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected UnsupportedAddressTypeException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _UnsupportedAddressTypeException22656;
		public UnsupportedAddressTypeException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.UnsupportedAddressTypeException._UnsupportedAddressTypeException22656.native == global::System.IntPtr.Zero)
				global::java.nio.channels.UnsupportedAddressTypeException._UnsupportedAddressTypeException22656 = @__env.GetMethodIDNoThrow(global::java.nio.channels.UnsupportedAddressTypeException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.UnsupportedAddressTypeException.staticClass, global::java.nio.channels.UnsupportedAddressTypeException._UnsupportedAddressTypeException22656);
			Init(@__env, handle);
		}
		static UnsupportedAddressTypeException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.UnsupportedAddressTypeException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/UnsupportedAddressTypeException"));
		}
		internal static void InitJNI()
		{
		}
	}
}