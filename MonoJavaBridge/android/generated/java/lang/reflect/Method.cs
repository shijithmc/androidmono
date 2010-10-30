namespace java.lang.reflect
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Method : java.lang.reflect.AccessibleObject, GenericDeclaration, Member
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Method(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _invoke21097;
		public global::java.lang.Object invoke(java.lang.Object arg0, java.lang.Object[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.reflect.Method.staticClass, "invoke", "(Ljava/lang/Object;[Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.lang.reflect.Method._invoke21097, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _equals21098;
		public sealed override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.reflect.Method.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.lang.reflect.Method._equals21098, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString21099;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.reflect.Method.staticClass, "toString", "()Ljava/lang/String;", ref global::java.lang.reflect.Method._toString21099) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode21100;
		public sealed override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.reflect.Method.staticClass, "hashCode", "()I", ref global::java.lang.reflect.Method._hashCode21100);
		}
		public new int Modifiers
		{
			get
			{
				return getModifiers();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getModifiers21101;
		public int getModifiers()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.reflect.Method.staticClass, "getModifiers", "()I", ref global::java.lang.reflect.Method._getModifiers21101);
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getName21102;
		public global::java.lang.String getName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.reflect.Method.staticClass, "getName", "()Ljava/lang/String;", ref global::java.lang.reflect.Method._getName21102) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isSynthetic21103;
		public bool isSynthetic()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.reflect.Method.staticClass, "isSynthetic", "()Z", ref global::java.lang.reflect.Method._isSynthetic21103);
		}
		public new global::java.lang.reflect.TypeVariable[] TypeParameters
		{
			get
			{
				return getTypeParameters();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTypeParameters21104;
		public global::java.lang.reflect.TypeVariable[] getTypeParameters()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.reflect.TypeVariable>(this, global::java.lang.reflect.Method.staticClass, "getTypeParameters", "()[Ljava/lang/reflect/TypeVariable;", ref global::java.lang.reflect.Method._getTypeParameters21104) as java.lang.reflect.TypeVariable[];
		}
		public new global::java.lang.Class DeclaringClass
		{
			get
			{
				return getDeclaringClass();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDeclaringClass21105;
		public global::java.lang.Class getDeclaringClass()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Class>(this, global::java.lang.reflect.Method.staticClass, "getDeclaringClass", "()Ljava/lang/Class;", ref global::java.lang.reflect.Method._getDeclaringClass21105) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _getAnnotation21106;
		public sealed override global::java.lang.annotation.Annotation getAnnotation(java.lang.Class arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.annotation.Annotation>(this, global::java.lang.reflect.Method.staticClass, "getAnnotation", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;", ref global::java.lang.reflect.Method._getAnnotation21106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.annotation.Annotation;
		}
		public new global::java.lang.annotation.Annotation[] DeclaredAnnotations
		{
			get
			{
				return getDeclaredAnnotations();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDeclaredAnnotations21107;
		public sealed override global::java.lang.annotation.Annotation[] getDeclaredAnnotations()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.annotation.Annotation>(this, global::java.lang.reflect.Method.staticClass, "getDeclaredAnnotations", "()[Ljava/lang/annotation/Annotation;", ref global::java.lang.reflect.Method._getDeclaredAnnotations21107) as java.lang.annotation.Annotation[];
		}
		public new global::java.lang.Class ReturnType
		{
			get
			{
				return getReturnType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getReturnType21108;
		public global::java.lang.Class getReturnType()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Class>(this, global::java.lang.reflect.Method.staticClass, "getReturnType", "()Ljava/lang/Class;", ref global::java.lang.reflect.Method._getReturnType21108) as java.lang.Class;
		}
		public new global::java.lang.Class[] ParameterTypes
		{
			get
			{
				return getParameterTypes();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getParameterTypes21109;
		public global::java.lang.Class[] getParameterTypes()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Class>(this, global::java.lang.reflect.Method.staticClass, "getParameterTypes", "()[Ljava/lang/Class;", ref global::java.lang.reflect.Method._getParameterTypes21109) as java.lang.Class[];
		}
		internal static global::MonoJavaBridge.MethodId _toGenericString21110;
		public global::java.lang.String toGenericString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.reflect.Method.staticClass, "toGenericString", "()Ljava/lang/String;", ref global::java.lang.reflect.Method._toGenericString21110) as java.lang.String;
		}
		public new global::java.lang.reflect.Type GenericReturnType
		{
			get
			{
				return getGenericReturnType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGenericReturnType21111;
		public global::java.lang.reflect.Type getGenericReturnType()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.reflect.Type>(this, global::java.lang.reflect.Method.staticClass, "getGenericReturnType", "()Ljava/lang/reflect/Type;", ref global::java.lang.reflect.Method._getGenericReturnType21111) as java.lang.reflect.Type;
		}
		public new global::java.lang.reflect.Type[] GenericParameterTypes
		{
			get
			{
				return getGenericParameterTypes();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGenericParameterTypes21112;
		public global::java.lang.reflect.Type[] getGenericParameterTypes()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.reflect.Type>(this, global::java.lang.reflect.Method.staticClass, "getGenericParameterTypes", "()[Ljava/lang/reflect/Type;", ref global::java.lang.reflect.Method._getGenericParameterTypes21112) as java.lang.reflect.Type[];
		}
		public new global::java.lang.Class[] ExceptionTypes
		{
			get
			{
				return getExceptionTypes();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getExceptionTypes21113;
		public global::java.lang.Class[] getExceptionTypes()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Class>(this, global::java.lang.reflect.Method.staticClass, "getExceptionTypes", "()[Ljava/lang/Class;", ref global::java.lang.reflect.Method._getExceptionTypes21113) as java.lang.Class[];
		}
		public new global::java.lang.reflect.Type[] GenericExceptionTypes
		{
			get
			{
				return getGenericExceptionTypes();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGenericExceptionTypes21114;
		public global::java.lang.reflect.Type[] getGenericExceptionTypes()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.reflect.Type>(this, global::java.lang.reflect.Method.staticClass, "getGenericExceptionTypes", "()[Ljava/lang/reflect/Type;", ref global::java.lang.reflect.Method._getGenericExceptionTypes21114) as java.lang.reflect.Type[];
		}
		internal static global::MonoJavaBridge.MethodId _isBridge21115;
		public bool isBridge()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.reflect.Method.staticClass, "isBridge", "()Z", ref global::java.lang.reflect.Method._isBridge21115);
		}
		internal static global::MonoJavaBridge.MethodId _isVarArgs21116;
		public bool isVarArgs()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.reflect.Method.staticClass, "isVarArgs", "()Z", ref global::java.lang.reflect.Method._isVarArgs21116);
		}
		public new global::java.lang.Object DefaultValue
		{
			get
			{
				return getDefaultValue();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultValue21117;
		public global::java.lang.Object getDefaultValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.reflect.Method.staticClass, "getDefaultValue", "()Ljava/lang/Object;", ref global::java.lang.reflect.Method._getDefaultValue21117) as java.lang.Object;
		}
		public new global::java.lang.annotation.Annotation[][] ParameterAnnotations
		{
			get
			{
				return getParameterAnnotations();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getParameterAnnotations21118;
		public global::java.lang.annotation.Annotation[][] getParameterAnnotations()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.annotation.Annotation[]>(this, global::java.lang.reflect.Method.staticClass, "getParameterAnnotations", "()[[Ljava/lang/annotation/Annotation;", ref global::java.lang.reflect.Method._getParameterAnnotations21118) as java.lang.annotation.Annotation[][];
		}
		static Method()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.reflect.Method.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/reflect/Method"));
		}
		internal static void InitJNI()
		{
		}
	}
}