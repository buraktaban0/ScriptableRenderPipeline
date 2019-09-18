using System.Collections.Generic;
using UnityEngine.Rendering;

namespace UnityEditor.ShaderGraph.Internal
{
    public class ShaderStruct
    {
        public string name;
        public ShaderSubscript[] subscripts;
    }
    
    public class ShaderSubscript
    {
        public static ShaderValueType concreteType;
        public static string name;
        public static string semantic;
        public static string conditional;
        public static string generatedType;
        public enum SubscriptType 
        {
            Static,
            Optional,
            Generated
        }
        public static SubscriptType subscriptType;
        public static void Create(ShaderValueType valueType, string subscriptName, string subscriptSemantic = "", string subscriptConditional = "")
        {
            subscriptType = SubscriptType.Static;
            concreteType = valueType;
            name = subscriptName;
            semantic = subscriptSemantic;
            conditional = subscriptConditional;
        }

        public static void CreateOptional(ShaderValueType valueType, string subscriptName, string subscriptSemantic = "", string subscriptConditional = "")
        {
            subscriptType = SubscriptType.Optional;
            concreteType = valueType;
            name = subscriptName;
            semantic = subscriptSemantic;
            conditional = subscriptConditional;
        }

        public static void CreateGenerated(string valueType, string subscriptName, string subscriptSemantic = "", string subscriptConditional = "")
        {
            subscriptType = SubscriptType.Generated;
            generatedType = valueType;
            name = subscriptName;
            semantic = subscriptSemantic;
            conditional = subscriptConditional;
        }
    }
}
