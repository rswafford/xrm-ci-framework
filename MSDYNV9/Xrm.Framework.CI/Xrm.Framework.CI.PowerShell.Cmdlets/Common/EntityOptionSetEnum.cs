//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Xrm.Framework.CI.PowerShell.Cmdlets.Common
{
    internal sealed class EntityOptionSetEnum
    {
        [System.Diagnostics.DebuggerNonUserCode()]
        public static System.Nullable<int> GetEnum(Microsoft.Xrm.Sdk.Entity entity, string attributeLogicalName)
        {
            if (entity.Attributes.ContainsKey(attributeLogicalName))
            {
                Microsoft.Xrm.Sdk.OptionSetValue value = entity.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>(attributeLogicalName);
                if (value != null)
                {
                    return value.Value;
                }
            }
            return null;
        }
    }
}