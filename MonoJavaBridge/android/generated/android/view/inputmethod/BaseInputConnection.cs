namespace android.view.inputmethod
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BaseInputConnection : java.lang.Object, InputConnection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BaseInputConnection(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setSelection15776;
		public virtual bool setSelection(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.BaseInputConnection.staticClass, "setSelection", "(II)Z", ref global::android.view.inputmethod.BaseInputConnection._setSelection15776, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _beginBatchEdit15777;
		public virtual bool beginBatchEdit()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.BaseInputConnection.staticClass, "beginBatchEdit", "()Z", ref global::android.view.inputmethod.BaseInputConnection._beginBatchEdit15777);
		}
		internal static global::MonoJavaBridge.MethodId _endBatchEdit15778;
		public virtual bool endBatchEdit()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.BaseInputConnection.staticClass, "endBatchEdit", "()Z", ref global::android.view.inputmethod.BaseInputConnection._endBatchEdit15778);
		}
		internal static global::MonoJavaBridge.MethodId _getTextBeforeCursor15779;
		public virtual global::java.lang.CharSequence getTextBeforeCursor(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.view.inputmethod.BaseInputConnection.staticClass, "getTextBeforeCursor", "(II)Ljava/lang/CharSequence;", ref global::android.view.inputmethod.BaseInputConnection._getTextBeforeCursor15779, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _getTextAfterCursor15780;
		public virtual global::java.lang.CharSequence getTextAfterCursor(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.view.inputmethod.BaseInputConnection.staticClass, "getTextAfterCursor", "(II)Ljava/lang/CharSequence;", ref global::android.view.inputmethod.BaseInputConnection._getTextAfterCursor15780, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _getCursorCapsMode15781;
		public virtual int getCursorCapsMode(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.inputmethod.BaseInputConnection.staticClass, "getCursorCapsMode", "(I)I", ref global::android.view.inputmethod.BaseInputConnection._getCursorCapsMode15781, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getExtractedText15782;
		public virtual global::android.view.inputmethod.ExtractedText getExtractedText(android.view.inputmethod.ExtractedTextRequest arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.inputmethod.BaseInputConnection.staticClass, "getExtractedText", "(Landroid/view/inputmethod/ExtractedTextRequest;I)Landroid/view/inputmethod/ExtractedText;", ref global::android.view.inputmethod.BaseInputConnection._getExtractedText15782, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.view.inputmethod.ExtractedText;
		}
		internal static global::MonoJavaBridge.MethodId _deleteSurroundingText15783;
		public virtual bool deleteSurroundingText(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.BaseInputConnection.staticClass, "deleteSurroundingText", "(II)Z", ref global::android.view.inputmethod.BaseInputConnection._deleteSurroundingText15783, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setComposingText15784;
		public virtual bool setComposingText(java.lang.CharSequence arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.BaseInputConnection.staticClass, "setComposingText", "(Ljava/lang/CharSequence;I)Z", ref global::android.view.inputmethod.BaseInputConnection._setComposingText15784, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public bool setComposingText(string arg0, int arg1)
		{
			return setComposingText((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _finishComposingText15785;
		public virtual bool finishComposingText()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.BaseInputConnection.staticClass, "finishComposingText", "()Z", ref global::android.view.inputmethod.BaseInputConnection._finishComposingText15785);
		}
		internal static global::MonoJavaBridge.MethodId _commitText15786;
		public virtual bool commitText(java.lang.CharSequence arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.BaseInputConnection.staticClass, "commitText", "(Ljava/lang/CharSequence;I)Z", ref global::android.view.inputmethod.BaseInputConnection._commitText15786, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public bool commitText(string arg0, int arg1)
		{
			return commitText((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _commitCompletion15787;
		public virtual bool commitCompletion(android.view.inputmethod.CompletionInfo arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.BaseInputConnection.staticClass, "commitCompletion", "(Landroid/view/inputmethod/CompletionInfo;)Z", ref global::android.view.inputmethod.BaseInputConnection._commitCompletion15787, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _performEditorAction15788;
		public virtual bool performEditorAction(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.BaseInputConnection.staticClass, "performEditorAction", "(I)Z", ref global::android.view.inputmethod.BaseInputConnection._performEditorAction15788, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _performContextMenuAction15789;
		public virtual bool performContextMenuAction(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.BaseInputConnection.staticClass, "performContextMenuAction", "(I)Z", ref global::android.view.inputmethod.BaseInputConnection._performContextMenuAction15789, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendKeyEvent15790;
		public virtual bool sendKeyEvent(android.view.KeyEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.BaseInputConnection.staticClass, "sendKeyEvent", "(Landroid/view/KeyEvent;)Z", ref global::android.view.inputmethod.BaseInputConnection._sendKeyEvent15790, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clearMetaKeyStates15791;
		public virtual bool clearMetaKeyStates(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.BaseInputConnection.staticClass, "clearMetaKeyStates", "(I)Z", ref global::android.view.inputmethod.BaseInputConnection._clearMetaKeyStates15791, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _reportFullscreenMode15792;
		public virtual bool reportFullscreenMode(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.BaseInputConnection.staticClass, "reportFullscreenMode", "(Z)Z", ref global::android.view.inputmethod.BaseInputConnection._reportFullscreenMode15792, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _performPrivateCommand15793;
		public virtual bool performPrivateCommand(java.lang.String arg0, android.os.Bundle arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.BaseInputConnection.staticClass, "performPrivateCommand", "(Ljava/lang/String;Landroid/os/Bundle;)Z", ref global::android.view.inputmethod.BaseInputConnection._performPrivateCommand15793, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _removeComposingSpans15794;
		public static void removeComposingSpans(android.text.Spannable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.inputmethod.BaseInputConnection._removeComposingSpans15794.native == global::System.IntPtr.Zero)
				global::android.view.inputmethod.BaseInputConnection._removeComposingSpans15794 = @__env.GetStaticMethodIDNoThrow(global::android.view.inputmethod.BaseInputConnection.staticClass, "removeComposingSpans", "(Landroid/text/Spannable;)V");
			@__env.CallStaticVoidMethod(android.view.inputmethod.BaseInputConnection.staticClass, global::android.view.inputmethod.BaseInputConnection._removeComposingSpans15794, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static global::android.text.Spannable ComposingSpans
		{
			set
			{
				setComposingSpans(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setComposingSpans15795;
		public static void setComposingSpans(android.text.Spannable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.inputmethod.BaseInputConnection._setComposingSpans15795.native == global::System.IntPtr.Zero)
				global::android.view.inputmethod.BaseInputConnection._setComposingSpans15795 = @__env.GetStaticMethodIDNoThrow(global::android.view.inputmethod.BaseInputConnection.staticClass, "setComposingSpans", "(Landroid/text/Spannable;)V");
			@__env.CallStaticVoidMethod(android.view.inputmethod.BaseInputConnection.staticClass, global::android.view.inputmethod.BaseInputConnection._setComposingSpans15795, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getComposingSpanStart15796;
		public static int getComposingSpanStart(android.text.Spannable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.inputmethod.BaseInputConnection._getComposingSpanStart15796.native == global::System.IntPtr.Zero)
				global::android.view.inputmethod.BaseInputConnection._getComposingSpanStart15796 = @__env.GetStaticMethodIDNoThrow(global::android.view.inputmethod.BaseInputConnection.staticClass, "getComposingSpanStart", "(Landroid/text/Spannable;)I");
			return @__env.CallStaticIntMethod(android.view.inputmethod.BaseInputConnection.staticClass, global::android.view.inputmethod.BaseInputConnection._getComposingSpanStart15796, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getComposingSpanEnd15797;
		public static int getComposingSpanEnd(android.text.Spannable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.inputmethod.BaseInputConnection._getComposingSpanEnd15797.native == global::System.IntPtr.Zero)
				global::android.view.inputmethod.BaseInputConnection._getComposingSpanEnd15797 = @__env.GetStaticMethodIDNoThrow(global::android.view.inputmethod.BaseInputConnection.staticClass, "getComposingSpanEnd", "(Landroid/text/Spannable;)I");
			return @__env.CallStaticIntMethod(android.view.inputmethod.BaseInputConnection.staticClass, global::android.view.inputmethod.BaseInputConnection._getComposingSpanEnd15797, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.text.Editable Editable
		{
			get
			{
				return getEditable();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEditable15798;
		public virtual global::android.text.Editable getEditable()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.text.Editable>(this, global::android.view.inputmethod.BaseInputConnection.staticClass, "getEditable", "()Landroid/text/Editable;", ref global::android.view.inputmethod.BaseInputConnection._getEditable15798) as android.text.Editable;
		}
		internal static global::MonoJavaBridge.MethodId _BaseInputConnection15799;
		public BaseInputConnection(android.view.View arg0, bool arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.inputmethod.BaseInputConnection._BaseInputConnection15799.native == global::System.IntPtr.Zero)
				global::android.view.inputmethod.BaseInputConnection._BaseInputConnection15799 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.BaseInputConnection.staticClass, "<init>", "(Landroid/view/View;Z)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.inputmethod.BaseInputConnection.staticClass, global::android.view.inputmethod.BaseInputConnection._BaseInputConnection15799, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static BaseInputConnection()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.inputmethod.BaseInputConnection.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/inputmethod/BaseInputConnection"));
		}
		internal static void InitJNI()
		{
		}
	}
}