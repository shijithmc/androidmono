namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AsynchronousCloseException : java.nio.channels.ClosedChannelException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AsynchronousCloseException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _AsynchronousCloseException22399;
		public AsynchronousCloseException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.AsynchronousCloseException._AsynchronousCloseException22399.native == global::System.IntPtr.Zero)
				global::java.nio.channels.AsynchronousCloseException._AsynchronousCloseException22399 = @__env.GetMethodIDNoThrow(global::java.nio.channels.AsynchronousCloseException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.AsynchronousCloseException.staticClass, global::java.nio.channels.AsynchronousCloseException._AsynchronousCloseException22399);
			Init(@__env, handle);
		}
		static AsynchronousCloseException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.AsynchronousCloseException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/AsynchronousCloseException"));
		}
		internal static void InitJNI()
		{
		}
	}
}