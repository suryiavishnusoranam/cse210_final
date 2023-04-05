namespace FinalProject
{
    public class Activity
    {
        private string _vsActivityName = "";
        private string _vsDescription = "";

        public string StartMessage()
        {
            return $"Welcome to the {_vsActivityName}! {_vsDescription}";
        }

        public string GetActivityName()
        {
            return _vsActivityName;
        }

        public void SetActivityName(string vsActivityName)
        {
            _vsActivityName = vsActivityName;
        }

        public string GetDescription()
        {
            return _vsDescription;
        }

        public void SetDescription(string vsdescription)
        {
            _vsDescription = vsdescription;
        }
        public string EndMessage()
        {
            return $"Well done! You've finished!";
        }

    }
}