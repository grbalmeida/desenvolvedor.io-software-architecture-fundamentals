namespace DesignPatterns.Composite
{
    public class CompositeExecution
    {
        public static void Execute()
        {
            var registrationValidation = new Message("The registration was not carried out!");

            var userFormError = new Message("The user entered an invalid name");

            var formNameSize = new InputFormMessage("The name must be longer than 2 characters");
            var emptyNameForm = new InputFormMessage("The name cannot have numbers");

            userFormError.AddChild(formNameSize);
            userFormError.AddChild(emptyNameForm);

            registrationValidation.AddChild(userFormError);

            var domainUserError = new Message("Problems processing the user registration");

            var cpfUserDomain = new DomainMessage("The informed CPF is in use!");
            var emailUserDomain = new DomainMessage("The informed email is in use!");

            domainUserError.AddChild(cpfUserDomain);
            domainUserError.AddChild(emailUserDomain);

            registrationValidation.AddChild(domainUserError);

            var level1Message = new Message("Level 1");
            var level2Message = new Message("Level 2");
            var level3Message = new Message("Level 3");
            var level4Message = new Message("Level 4");
            var level5Message = new Message("Level 5");

            level4Message.AddChild(level5Message);
            level3Message.AddChild(level4Message);
            level2Message.AddChild(level3Message);
            level1Message.AddChild(level2Message);

            registrationValidation.AddChild(level1Message);

            registrationValidation.DisplayMessages(2);
        }
    }
}