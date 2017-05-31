using System;

namespace RefactoringExamples.IntroduceExplainingVariable
{
    public class UserInterface
    {
        private readonly ICollaborator _collaborator;
        private bool _initialised;

        public UserInterface(ICollaborator collaborator)
        {
            _collaborator = collaborator;
            _initialised = false;
        }

        public void Initialise()
        {
            _initialised = true;
        }

        public void React(string platform, string browser, int resize)
        {
            bool isMacOs = platform.ToUpper().IndexOf("MAC", StringComparison.Ordinal) > -1;
            bool isIeBrowser = browser.ToUpper().IndexOf("IE", StringComparison.Ordinal) > -1;

            if (isMacOs && isIeBrowser && WasInitialised() &&
                resize > 0)
            {
                DoSomething();
            }
        }

        private bool WasInitialised()
        {
            return _initialised;
        }

        private void DoSomething()
        {
            _collaborator.DoSomething();
        }
    }

    public interface ICollaborator
    {
        void DoSomething();
    }
}