namespace java.io
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.io.ObjectStreamException_))]
	public abstract partial class ObjectStreamException : java.io.IOException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ObjectStreamException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _ObjectStreamException19336;
		protected ObjectStreamException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.ObjectStreamException._ObjectStreamException19336.native == global::System.IntPtr.Zero)
				global::java.io.ObjectStreamException._ObjectStreamException19336 = @__env.GetMethodIDNoThrow(global::java.io.ObjectStreamException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.ObjectStreamException.staticClass, global::java.io.ObjectStreamException._ObjectStreamException19336, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ObjectStreamException19337;
		protected ObjectStreamException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.ObjectStreamException._ObjectStreamException19337.native == global::System.IntPtr.Zero)
				global::java.io.ObjectStreamException._ObjectStreamException19337 = @__env.GetMethodIDNoThrow(global::java.io.ObjectStreamException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.ObjectStreamException.staticClass, global::java.io.ObjectStreamException._ObjectStreamException19337);
			Init(@__env, handle);
		}
		static ObjectStreamException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.ObjectStreamException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/ObjectStreamException"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.io.ObjectStreamException))]
	internal sealed partial class ObjectStreamException_ : java.io.ObjectStreamException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ObjectStreamException_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static ObjectStreamException_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.ObjectStreamException_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/ObjectStreamException"));
		}
		internal static void InitJNI()
		{
		}
	}
}