using System.ComponentModel.DataAnnotations;

namespace ValidacaoCustomizada
{
    public class MinhaValidacao : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if(((string)value).Length == 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
