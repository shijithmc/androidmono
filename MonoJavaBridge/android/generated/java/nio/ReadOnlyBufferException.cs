namespace java.nio
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ReadOnlyBufferException : java.lang.UnsupportedOperationException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ReadOnlyBufferException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _ReadOnlyBufferException22360;
		public ReadOnlyBufferException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.ReadOnlyBufferException._ReadOnlyBufferException22360.native == global::System.IntPtr.Zero)
				global::java.nio.ReadOnlyBufferException._ReadOnlyBufferException22360 = @__env.GetMethodIDNoThrow(global::java.nio.ReadOnlyBufferException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.ReadOnlyBufferException.staticClass, global::java.nio.ReadOnlyBufferException._ReadOnlyBufferException22360);
			Init(@__env, handle);
		}
		static ReadOnlyBufferException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.ReadOnlyBufferException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/ReadOnlyBufferException"));
		}
		internal static void InitJNI()
		{
		}
	}
}