namespace java.io
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.io.Closeable_))]
	public interface Closeable  : global::MonoJavaBridge.IJavaObject 
	{
		void close();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.io.Closeable))]
	public sealed partial class Closeable_ : java.lang.Object, Closeable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Closeable_()
		{
			InitJNI();
		}
		internal Closeable_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close12494;
		 void java.io.Closeable.close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.Closeable_._close12494);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.Closeable_.staticClass, global::java.io.Closeable_._close12494);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.Closeable_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/Closeable"));
			global::java.io.Closeable_._close12494 = @__env.GetMethodIDNoThrow(global::java.io.Closeable_.staticClass, "close", "()V");
		}
	}
}
