namespace org.apache.http.impl.conn.tsccm
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ThreadSafeClientConnManager : java.lang.Object, org.apache.http.conn.ClientConnectionManager
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ThreadSafeClientConnManager()
		{
			InitJNI();
		}
		protected ThreadSafeClientConnManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _shutdown33054;
		public virtual void shutdown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager._shutdown33054);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager.staticClass, global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager._shutdown33054);
		}
		internal static global::MonoJavaBridge.MethodId _finalize33055;
		protected override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager._finalize33055);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager.staticClass, global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager._finalize33055);
		}
		public new global::org.apache.http.conn.scheme.SchemeRegistry SchemeRegistry
		{
			get
			{
				return getSchemeRegistry();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSchemeRegistry33056;
		public virtual global::org.apache.http.conn.scheme.SchemeRegistry getSchemeRegistry() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.scheme.SchemeRegistry>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager._getSchemeRegistry33056)) as org.apache.http.conn.scheme.SchemeRegistry;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.scheme.SchemeRegistry>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager.staticClass, global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager._getSchemeRegistry33056)) as org.apache.http.conn.scheme.SchemeRegistry;
		}
		internal static global::MonoJavaBridge.MethodId _requestConnection33057;
		public virtual global::org.apache.http.conn.ClientConnectionRequest requestConnection(org.apache.http.conn.routing.HttpRoute arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.ClientConnectionRequest>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager._requestConnection33057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.conn.ClientConnectionRequest;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.ClientConnectionRequest>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager.staticClass, global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager._requestConnection33057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.conn.ClientConnectionRequest;
		}
		internal static global::MonoJavaBridge.MethodId _releaseConnection33058;
		public virtual void releaseConnection(org.apache.http.conn.ManagedClientConnection arg0, long arg1, java.util.concurrent.TimeUnit arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager._releaseConnection33058, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager.staticClass, global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager._releaseConnection33058, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _closeIdleConnections33059;
		public virtual void closeIdleConnections(long arg0, java.util.concurrent.TimeUnit arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager._closeIdleConnections33059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager.staticClass, global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager._closeIdleConnections33059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _closeExpiredConnections33060;
		public virtual void closeExpiredConnections() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager._closeExpiredConnections33060);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager.staticClass, global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager._closeExpiredConnections33060);
		}
		internal static global::MonoJavaBridge.MethodId _createConnectionOperator33061;
		protected virtual global::org.apache.http.conn.ClientConnectionOperator createConnectionOperator(org.apache.http.conn.scheme.SchemeRegistry arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.ClientConnectionOperator>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager._createConnectionOperator33061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.conn.ClientConnectionOperator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.ClientConnectionOperator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager.staticClass, global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager._createConnectionOperator33061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.conn.ClientConnectionOperator;
		}
		internal static global::MonoJavaBridge.MethodId _createConnectionPool33062;
		protected virtual global::org.apache.http.impl.conn.tsccm.AbstractConnPool createConnectionPool(org.apache.http.@params.HttpParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager._createConnectionPool33062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.impl.conn.tsccm.AbstractConnPool;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager.staticClass, global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager._createConnectionPool33062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.impl.conn.tsccm.AbstractConnPool;
		}
		internal static global::MonoJavaBridge.MethodId _getConnectionsInPool33063;
		public virtual int getConnectionsInPool(org.apache.http.conn.routing.HttpRoute arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager._getConnectionsInPool33063, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager.staticClass, global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager._getConnectionsInPool33063, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int ConnectionsInPool
		{
			get
			{
				return getConnectionsInPool();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getConnectionsInPool33064;
		public virtual int getConnectionsInPool() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager._getConnectionsInPool33064);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager.staticClass, global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager._getConnectionsInPool33064);
		}
		internal static global::MonoJavaBridge.MethodId _ThreadSafeClientConnManager33065;
		public ThreadSafeClientConnManager(org.apache.http.@params.HttpParams arg0, org.apache.http.conn.scheme.SchemeRegistry arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager.staticClass, global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager._ThreadSafeClientConnManager33065, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/tsccm/ThreadSafeClientConnManager"));
			global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager._shutdown33054 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager.staticClass, "shutdown", "()V");
			global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager._finalize33055 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager.staticClass, "finalize", "()V");
			global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager._getSchemeRegistry33056 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager.staticClass, "getSchemeRegistry", "()Lorg/apache/http/conn/scheme/SchemeRegistry;");
			global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager._requestConnection33057 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager.staticClass, "requestConnection", "(Lorg/apache/http/conn/routing/HttpRoute;Ljava/lang/Object;)Lorg/apache/http/conn/ClientConnectionRequest;");
			global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager._releaseConnection33058 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager.staticClass, "releaseConnection", "(Lorg/apache/http/conn/ManagedClientConnection;JLjava/util/concurrent/TimeUnit;)V");
			global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager._closeIdleConnections33059 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager.staticClass, "closeIdleConnections", "(JLjava/util/concurrent/TimeUnit;)V");
			global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager._closeExpiredConnections33060 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager.staticClass, "closeExpiredConnections", "()V");
			global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager._createConnectionOperator33061 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager.staticClass, "createConnectionOperator", "(Lorg/apache/http/conn/scheme/SchemeRegistry;)Lorg/apache/http/conn/ClientConnectionOperator;");
			global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager._createConnectionPool33062 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager.staticClass, "createConnectionPool", "(Lorg/apache/http/@params/HttpParams;)Lorg/apache/http/impl/conn/tsccm/AbstractConnPool;");
			global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager._getConnectionsInPool33063 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager.staticClass, "getConnectionsInPool", "(Lorg/apache/http/conn/routing/HttpRoute;)I");
			global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager._getConnectionsInPool33064 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager.staticClass, "getConnectionsInPool", "()I");
			global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager._ThreadSafeClientConnManager33065 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.ThreadSafeClientConnManager.staticClass, "<init>", "(Lorg/apache/http/@params/HttpParams;Lorg/apache/http/conn/scheme/SchemeRegistry;)V");
		}
	}
}
