namespace org.apache.http.entity
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class HttpEntityWrapper : java.lang.Object, HttpEntity
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected HttpEntityWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.io.InputStream Content
		{
			get
			{
				return getContent();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContent32547;
		public virtual global::java.io.InputStream getContent()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.entity.HttpEntityWrapper.staticClass, "getContent", "()Ljava/io/InputStream;", ref global::org.apache.http.entity.HttpEntityWrapper._getContent32547) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _writeTo32548;
		public virtual void writeTo(java.io.OutputStream arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.entity.HttpEntityWrapper.staticClass, "writeTo", "(Ljava/io/OutputStream;)V", ref global::org.apache.http.entity.HttpEntityWrapper._writeTo32548, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::org.apache.http.Header ContentType
		{
			get
			{
				return getContentType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContentType32549;
		public virtual global::org.apache.http.Header getContentType()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.Header>(this, global::org.apache.http.entity.HttpEntityWrapper.staticClass, "getContentType", "()Lorg/apache/http/Header;", ref global::org.apache.http.entity.HttpEntityWrapper._getContentType32549) as org.apache.http.Header;
		}
		public new long ContentLength
		{
			get
			{
				return getContentLength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContentLength32550;
		public virtual long getContentLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::org.apache.http.entity.HttpEntityWrapper.staticClass, "getContentLength", "()J", ref global::org.apache.http.entity.HttpEntityWrapper._getContentLength32550);
		}
		public new global::org.apache.http.Header ContentEncoding
		{
			get
			{
				return getContentEncoding();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContentEncoding32551;
		public virtual global::org.apache.http.Header getContentEncoding()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.Header>(this, global::org.apache.http.entity.HttpEntityWrapper.staticClass, "getContentEncoding", "()Lorg/apache/http/Header;", ref global::org.apache.http.entity.HttpEntityWrapper._getContentEncoding32551) as org.apache.http.Header;
		}
		internal static global::MonoJavaBridge.MethodId _isRepeatable32552;
		public virtual bool isRepeatable()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.entity.HttpEntityWrapper.staticClass, "isRepeatable", "()Z", ref global::org.apache.http.entity.HttpEntityWrapper._isRepeatable32552);
		}
		internal static global::MonoJavaBridge.MethodId _isChunked32553;
		public virtual bool isChunked()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.entity.HttpEntityWrapper.staticClass, "isChunked", "()Z", ref global::org.apache.http.entity.HttpEntityWrapper._isChunked32553);
		}
		internal static global::MonoJavaBridge.MethodId _isStreaming32554;
		public virtual bool isStreaming()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.entity.HttpEntityWrapper.staticClass, "isStreaming", "()Z", ref global::org.apache.http.entity.HttpEntityWrapper._isStreaming32554);
		}
		internal static global::MonoJavaBridge.MethodId _consumeContent32555;
		public virtual void consumeContent()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.entity.HttpEntityWrapper.staticClass, "consumeContent", "()V", ref global::org.apache.http.entity.HttpEntityWrapper._consumeContent32555);
		}
		internal static global::MonoJavaBridge.MethodId _HttpEntityWrapper32556;
		public HttpEntityWrapper(org.apache.http.HttpEntity arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.entity.HttpEntityWrapper._HttpEntityWrapper32556.native == global::System.IntPtr.Zero)
				global::org.apache.http.entity.HttpEntityWrapper._HttpEntityWrapper32556 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.HttpEntityWrapper.staticClass, "<init>", "(Lorg/apache/http/HttpEntity;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.entity.HttpEntityWrapper.staticClass, global::org.apache.http.entity.HttpEntityWrapper._HttpEntityWrapper32556, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static HttpEntityWrapper()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.entity.HttpEntityWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/entity/HttpEntityWrapper"));
		}
		internal static void InitJNI()
		{
		}
	}
}