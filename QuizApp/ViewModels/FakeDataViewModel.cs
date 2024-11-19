using QuizApp.Data;

namespace QuizApp.ViewModels
{
    public class FakeDataViewModel
    {
        private IFakeDB _fakeDB;
        public string Text { get; set; } = "This is a test";

        public FakeDataViewModel(IFakeDB fakeDB) 
        { 
            _fakeDB = fakeDB;
        }
    }
}
