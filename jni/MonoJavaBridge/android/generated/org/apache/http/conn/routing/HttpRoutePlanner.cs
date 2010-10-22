namespace org.apache.http.conn.routing
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.conn.routing.HttpRoutePlanner_))]
	public interface HttpRoutePlanner  : global::MonoJavaBridge.IJavaObject 
	{
		global::org.apache.http.conn.routing.HttpRoute determineRoute(org.apache.http.HttpHost arg0, org.apache.http.HttpRequest arg1, org.apache.http.protocol.HttpContext arg2);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.conn.routing.HttpRoutePlanner))]
	public sealed partial class HttpRoutePlanner_ : java.lang.Object, HttpRoutePlanner
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HttpRoutePlanner_()
		{
			InitJNI();
		}
		internal HttpRoutePlanner_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _determineRoute32128;
		 global::org.apache.http.conn.routing.HttpRoute org.apache.http.conn.routing.HttpRoutePlanner.determineRoute(org.apache.http.HttpHost arg0, org.apache.http.HttpRequest arg1, org.apache.http.protocol.HttpContext arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.routing.HttpRoute>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.HttpRoutePlanner_._determineRoute32128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.conn.routing.HttpRoute;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.routing.HttpRoute>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.routing.HttpRoutePlanner_.staticClass, global::org.apache.http.conn.routing.HttpRoutePlanner_._determineRoute32128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.conn.routing.HttpRoute;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.routing.HttpRoutePlanner_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/routing/HttpRoutePlanner"));
			global::org.apache.http.conn.routing.HttpRoutePlanner_._determineRoute32128 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.routing.HttpRoutePlanner_.staticClass, "determineRoute", "(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol/HttpContext;)Lorg/apache/http/conn/routing/HttpRoute;");
		}
	}
}
