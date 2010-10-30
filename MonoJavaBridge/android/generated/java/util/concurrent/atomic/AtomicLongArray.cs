namespace java.util.concurrent.atomic
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AtomicLongArray : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AtomicLongArray(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get27605;
		public virtual long get(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "get", "(I)J", ref global::java.util.concurrent.atomic.AtomicLongArray._get27605, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString27606;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "toString", "()Ljava/lang/String;", ref global::java.util.concurrent.atomic.AtomicLongArray._toString27606) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _length27607;
		public virtual int length()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "length", "()I", ref global::java.util.concurrent.atomic.AtomicLongArray._length27607);
		}
		internal static global::MonoJavaBridge.MethodId _set27608;
		public virtual void set(int arg0, long arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "set", "(IJ)V", ref global::java.util.concurrent.atomic.AtomicLongArray._set27608, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getAndAdd27609;
		public virtual long getAndAdd(int arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "getAndAdd", "(IJ)J", ref global::java.util.concurrent.atomic.AtomicLongArray._getAndAdd27609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _lazySet27610;
		public virtual void lazySet(int arg0, long arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "lazySet", "(IJ)V", ref global::java.util.concurrent.atomic.AtomicLongArray._lazySet27610, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getAndSet27611;
		public virtual long getAndSet(int arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "getAndSet", "(IJ)J", ref global::java.util.concurrent.atomic.AtomicLongArray._getAndSet27611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _compareAndSet27612;
		public virtual bool compareAndSet(int arg0, long arg1, long arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "compareAndSet", "(IJJ)Z", ref global::java.util.concurrent.atomic.AtomicLongArray._compareAndSet27612, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _weakCompareAndSet27613;
		public virtual bool weakCompareAndSet(int arg0, long arg1, long arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "weakCompareAndSet", "(IJJ)Z", ref global::java.util.concurrent.atomic.AtomicLongArray._weakCompareAndSet27613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getAndIncrement27614;
		public virtual long getAndIncrement(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "getAndIncrement", "(I)J", ref global::java.util.concurrent.atomic.AtomicLongArray._getAndIncrement27614, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getAndDecrement27615;
		public virtual long getAndDecrement(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "getAndDecrement", "(I)J", ref global::java.util.concurrent.atomic.AtomicLongArray._getAndDecrement27615, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _incrementAndGet27616;
		public virtual long incrementAndGet(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "incrementAndGet", "(I)J", ref global::java.util.concurrent.atomic.AtomicLongArray._incrementAndGet27616, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _decrementAndGet27617;
		public virtual long decrementAndGet(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "decrementAndGet", "(I)J", ref global::java.util.concurrent.atomic.AtomicLongArray._decrementAndGet27617, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAndGet27618;
		public virtual long addAndGet(int arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "addAndGet", "(IJ)J", ref global::java.util.concurrent.atomic.AtomicLongArray._addAndGet27618, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _AtomicLongArray27619;
		public AtomicLongArray(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.atomic.AtomicLongArray._AtomicLongArray27619.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.atomic.AtomicLongArray._AtomicLongArray27619 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.atomic.AtomicLongArray.staticClass, global::java.util.concurrent.atomic.AtomicLongArray._AtomicLongArray27619, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AtomicLongArray27620;
		public AtomicLongArray(long[] arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.atomic.AtomicLongArray._AtomicLongArray27620.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.atomic.AtomicLongArray._AtomicLongArray27620 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "<init>", "([J)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.atomic.AtomicLongArray.staticClass, global::java.util.concurrent.atomic.AtomicLongArray._AtomicLongArray27620, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static AtomicLongArray()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.atomic.AtomicLongArray.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/atomic/AtomicLongArray"));
		}
		internal static void InitJNI()
		{
		}
	}
}