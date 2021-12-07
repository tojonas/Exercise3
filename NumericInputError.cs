
namespace Exercise3
{
    public class NumericInputError : UserError
    {
        public override string UEMessage()
        {
            return @"You tried to use a numeric inputin a text only field. This fired an error!";
        }
    }
}
