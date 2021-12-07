
namespace Exercise3
{
    public class TextInputError : UserError
    {
        public override string UEMessage()
        {
            return @"You tried to use a text input in anumericonly field. This fired an error!";
        }
    }
}
