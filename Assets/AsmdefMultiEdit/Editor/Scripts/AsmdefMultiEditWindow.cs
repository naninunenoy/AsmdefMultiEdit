using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEditor.Compilation;
using UnityEngine;

namespace AsmdefMultiEdit.Editor{
    public class AsmdefMultiEditWindow : EditorWindow
    {
        [MenuItem("Window/Open Asmdef Multiple Edit Window")]
        public static void Open()
        {
            //対象アセットをロード
            var obj = AssetDatabase.LoadAssetAtPath<UnityEngine.Object>("Assets/AsmdefMultiEdit/Example/Piyo/AsmdefMultiEdit.Example.Piyo.asmdef");

            //存在すればPing
            if (obj)
                Selection.objects = new[] { obj };
            
            var window = CreateWindow<InspectorWindow>();
        }
    }
}
