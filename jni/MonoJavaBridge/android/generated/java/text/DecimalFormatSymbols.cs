namespace java.text
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DecimalFormatSymbols : java.lang.Object, java.lang.Cloneable, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DecimalFormatSymbols()
		{
			InitJNI();
		}
		protected DecimalFormatSymbols(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals25350;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._equals25350, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._equals25350, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode25351;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._hashCode25351);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._hashCode25351);
		}
		internal static global::MonoJavaBridge.MethodId _clone25352;
		public virtual global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._clone25352)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._clone25352)) as java.lang.Object;
		}
		public static global::java.text.DecimalFormatSymbols Instance
		{
			get
			{
				return getInstance();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInstance25353;
		public static global::java.text.DecimalFormatSymbols getInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._getInstance25353)) as java.text.DecimalFormatSymbols;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance25354;
		public static global::java.text.DecimalFormatSymbols getInstance(java.util.Locale arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._getInstance25354, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.DecimalFormatSymbols;
		}
		public static global::java.util.Locale[] AvailableLocales
		{
			get
			{
				return getAvailableLocales();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAvailableLocales25355;
		public static global::java.util.Locale[] getAvailableLocales() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.util.Locale>(@__env.CallStaticObjectMethod(java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._getAvailableLocales25355)) as java.util.Locale[];
		}
		public new char ZeroDigit
		{
			get
			{
				return getZeroDigit();
			}
			set
			{
				setZeroDigit(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getZeroDigit25356;
		public virtual char getZeroDigit() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._getZeroDigit25356);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._getZeroDigit25356);
		}
		public new global::java.util.Currency Currency
		{
			get
			{
				return getCurrency();
			}
			set
			{
				setCurrency(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCurrency25357;
		public virtual global::java.util.Currency getCurrency() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Currency>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._getCurrency25357)) as java.util.Currency;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Currency>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._getCurrency25357)) as java.util.Currency;
		}
		internal static global::MonoJavaBridge.MethodId _setCurrency25358;
		public virtual void setCurrency(java.util.Currency arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._setCurrency25358, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._setCurrency25358, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String NaN
		{
			get
			{
				return getNaN();
			}
			set
			{
				setNaN(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNaN25359;
		public virtual global::java.lang.String getNaN() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._getNaN25359)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._getNaN25359)) as java.lang.String;
		}
		public new global::java.lang.String Infinity
		{
			get
			{
				return getInfinity();
			}
			set
			{
				setInfinity(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInfinity25360;
		public virtual global::java.lang.String getInfinity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._getInfinity25360)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._getInfinity25360)) as java.lang.String;
		}
		public new char GroupingSeparator
		{
			get
			{
				return getGroupingSeparator();
			}
			set
			{
				setGroupingSeparator(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGroupingSeparator25361;
		public virtual char getGroupingSeparator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._getGroupingSeparator25361);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._getGroupingSeparator25361);
		}
		public new char MonetaryDecimalSeparator
		{
			get
			{
				return getMonetaryDecimalSeparator();
			}
			set
			{
				setMonetaryDecimalSeparator(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMonetaryDecimalSeparator25362;
		public virtual char getMonetaryDecimalSeparator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._getMonetaryDecimalSeparator25362);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._getMonetaryDecimalSeparator25362);
		}
		public new char DecimalSeparator
		{
			get
			{
				return getDecimalSeparator();
			}
			set
			{
				setDecimalSeparator(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDecimalSeparator25363;
		public virtual char getDecimalSeparator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._getDecimalSeparator25363);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._getDecimalSeparator25363);
		}
		public new global::java.lang.String ExponentSeparator
		{
			get
			{
				return getExponentSeparator();
			}
			set
			{
				setExponentSeparator(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getExponentSeparator25364;
		public virtual global::java.lang.String getExponentSeparator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._getExponentSeparator25364)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._getExponentSeparator25364)) as java.lang.String;
		}
		public new char MinusSign
		{
			get
			{
				return getMinusSign();
			}
			set
			{
				setMinusSign(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMinusSign25365;
		public virtual char getMinusSign() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._getMinusSign25365);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._getMinusSign25365);
		}
		public new global::java.lang.String InternationalCurrencySymbol
		{
			get
			{
				return getInternationalCurrencySymbol();
			}
			set
			{
				setInternationalCurrencySymbol(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInternationalCurrencySymbol25366;
		public virtual global::java.lang.String getInternationalCurrencySymbol() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._getInternationalCurrencySymbol25366)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._getInternationalCurrencySymbol25366)) as java.lang.String;
		}
		public new global::java.lang.String CurrencySymbol
		{
			get
			{
				return getCurrencySymbol();
			}
			set
			{
				setCurrencySymbol(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCurrencySymbol25367;
		public virtual global::java.lang.String getCurrencySymbol() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._getCurrencySymbol25367)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._getCurrencySymbol25367)) as java.lang.String;
		}
		public new char Percent
		{
			get
			{
				return getPercent();
			}
			set
			{
				setPercent(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPercent25368;
		public virtual char getPercent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._getPercent25368);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._getPercent25368);
		}
		public new char PerMill
		{
			get
			{
				return getPerMill();
			}
			set
			{
				setPerMill(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPerMill25369;
		public virtual char getPerMill() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._getPerMill25369);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._getPerMill25369);
		}
		public new char Digit
		{
			get
			{
				return getDigit();
			}
			set
			{
				setDigit(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDigit25370;
		public virtual char getDigit() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._getDigit25370);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._getDigit25370);
		}
		public new char PatternSeparator
		{
			get
			{
				return getPatternSeparator();
			}
			set
			{
				setPatternSeparator(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPatternSeparator25371;
		public virtual char getPatternSeparator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._getPatternSeparator25371);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._getPatternSeparator25371);
		}
		internal static global::MonoJavaBridge.MethodId _setZeroDigit25372;
		public virtual void setZeroDigit(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._setZeroDigit25372, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._setZeroDigit25372, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setGroupingSeparator25373;
		public virtual void setGroupingSeparator(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._setGroupingSeparator25373, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._setGroupingSeparator25373, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDecimalSeparator25374;
		public virtual void setDecimalSeparator(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._setDecimalSeparator25374, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._setDecimalSeparator25374, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPerMill25375;
		public virtual void setPerMill(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._setPerMill25375, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._setPerMill25375, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPercent25376;
		public virtual void setPercent(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._setPercent25376, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._setPercent25376, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDigit25377;
		public virtual void setDigit(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._setDigit25377, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._setDigit25377, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPatternSeparator25378;
		public virtual void setPatternSeparator(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._setPatternSeparator25378, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._setPatternSeparator25378, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setInfinity25379;
		public virtual void setInfinity(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._setInfinity25379, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._setInfinity25379, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setNaN25380;
		public virtual void setNaN(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._setNaN25380, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._setNaN25380, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMinusSign25381;
		public virtual void setMinusSign(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._setMinusSign25381, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._setMinusSign25381, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCurrencySymbol25382;
		public virtual void setCurrencySymbol(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._setCurrencySymbol25382, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._setCurrencySymbol25382, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setInternationalCurrencySymbol25383;
		public virtual void setInternationalCurrencySymbol(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._setInternationalCurrencySymbol25383, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._setInternationalCurrencySymbol25383, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMonetaryDecimalSeparator25384;
		public virtual void setMonetaryDecimalSeparator(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._setMonetaryDecimalSeparator25384, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._setMonetaryDecimalSeparator25384, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setExponentSeparator25385;
		public virtual void setExponentSeparator(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._setExponentSeparator25385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._setExponentSeparator25385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _DecimalFormatSymbols25386;
		public DecimalFormatSymbols()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._DecimalFormatSymbols25386);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DecimalFormatSymbols25387;
		public DecimalFormatSymbols(java.util.Locale arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._DecimalFormatSymbols25387, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.DecimalFormatSymbols.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/DecimalFormatSymbols"));
			global::java.text.DecimalFormatSymbols._equals25350 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.text.DecimalFormatSymbols._hashCode25351 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "hashCode", "()I");
			global::java.text.DecimalFormatSymbols._clone25352 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.text.DecimalFormatSymbols._getInstance25353 = @__env.GetStaticMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "getInstance", "()Ljava/text/DecimalFormatSymbols;");
			global::java.text.DecimalFormatSymbols._getInstance25354 = @__env.GetStaticMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "getInstance", "(Ljava/util/Locale;)Ljava/text/DecimalFormatSymbols;");
			global::java.text.DecimalFormatSymbols._getAvailableLocales25355 = @__env.GetStaticMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "getAvailableLocales", "()[Ljava/util/Locale;");
			global::java.text.DecimalFormatSymbols._getZeroDigit25356 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "getZeroDigit", "()C");
			global::java.text.DecimalFormatSymbols._getCurrency25357 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "getCurrency", "()Ljava/util/Currency;");
			global::java.text.DecimalFormatSymbols._setCurrency25358 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "setCurrency", "(Ljava/util/Currency;)V");
			global::java.text.DecimalFormatSymbols._getNaN25359 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "getNaN", "()Ljava/lang/String;");
			global::java.text.DecimalFormatSymbols._getInfinity25360 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "getInfinity", "()Ljava/lang/String;");
			global::java.text.DecimalFormatSymbols._getGroupingSeparator25361 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "getGroupingSeparator", "()C");
			global::java.text.DecimalFormatSymbols._getMonetaryDecimalSeparator25362 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "getMonetaryDecimalSeparator", "()C");
			global::java.text.DecimalFormatSymbols._getDecimalSeparator25363 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "getDecimalSeparator", "()C");
			global::java.text.DecimalFormatSymbols._getExponentSeparator25364 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "getExponentSeparator", "()Ljava/lang/String;");
			global::java.text.DecimalFormatSymbols._getMinusSign25365 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "getMinusSign", "()C");
			global::java.text.DecimalFormatSymbols._getInternationalCurrencySymbol25366 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "getInternationalCurrencySymbol", "()Ljava/lang/String;");
			global::java.text.DecimalFormatSymbols._getCurrencySymbol25367 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "getCurrencySymbol", "()Ljava/lang/String;");
			global::java.text.DecimalFormatSymbols._getPercent25368 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "getPercent", "()C");
			global::java.text.DecimalFormatSymbols._getPerMill25369 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "getPerMill", "()C");
			global::java.text.DecimalFormatSymbols._getDigit25370 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "getDigit", "()C");
			global::java.text.DecimalFormatSymbols._getPatternSeparator25371 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "getPatternSeparator", "()C");
			global::java.text.DecimalFormatSymbols._setZeroDigit25372 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "setZeroDigit", "(C)V");
			global::java.text.DecimalFormatSymbols._setGroupingSeparator25373 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "setGroupingSeparator", "(C)V");
			global::java.text.DecimalFormatSymbols._setDecimalSeparator25374 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "setDecimalSeparator", "(C)V");
			global::java.text.DecimalFormatSymbols._setPerMill25375 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "setPerMill", "(C)V");
			global::java.text.DecimalFormatSymbols._setPercent25376 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "setPercent", "(C)V");
			global::java.text.DecimalFormatSymbols._setDigit25377 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "setDigit", "(C)V");
			global::java.text.DecimalFormatSymbols._setPatternSeparator25378 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "setPatternSeparator", "(C)V");
			global::java.text.DecimalFormatSymbols._setInfinity25379 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "setInfinity", "(Ljava/lang/String;)V");
			global::java.text.DecimalFormatSymbols._setNaN25380 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "setNaN", "(Ljava/lang/String;)V");
			global::java.text.DecimalFormatSymbols._setMinusSign25381 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "setMinusSign", "(C)V");
			global::java.text.DecimalFormatSymbols._setCurrencySymbol25382 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "setCurrencySymbol", "(Ljava/lang/String;)V");
			global::java.text.DecimalFormatSymbols._setInternationalCurrencySymbol25383 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "setInternationalCurrencySymbol", "(Ljava/lang/String;)V");
			global::java.text.DecimalFormatSymbols._setMonetaryDecimalSeparator25384 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "setMonetaryDecimalSeparator", "(C)V");
			global::java.text.DecimalFormatSymbols._setExponentSeparator25385 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "setExponentSeparator", "(Ljava/lang/String;)V");
			global::java.text.DecimalFormatSymbols._DecimalFormatSymbols25386 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "<init>", "()V");
			global::java.text.DecimalFormatSymbols._DecimalFormatSymbols25387 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "<init>", "(Ljava/util/Locale;)V");
		}
	}
}
