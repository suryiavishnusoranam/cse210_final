using System;
// This is the parent class. All of the child classes will use attributes and methods from this class.

namespace FinalProject
{
    public class Activity
    {
        // Escapsulation where _vsActivityName and _vsDescription are made private
        private string _vsActivityName = "";
        private string _vsDescription = "";
        
        // Welcomes user and inherits Activity Name and Description from program.cs
        public string StartMessage()
        {
            return $"Welcome to the {_vsActivityName}! {_vsDescription}";
        }
        
        // Gets Activity Name from program.cs and sets it
        public string GetActivityName()
        {
            return _vsActivityName;
        }
        public void SetActivityName(string vsActivityName)
        {
            _vsActivityName = vsActivityName;
        }

        // Gets Activity Description from program.cs and sets it
        public string GetDescription()
        {
            return _vsDescription;
        }
        public void SetDescription(string vsdescription)
        {
            _vsDescription = vsdescription;
        }
        
        // Returns game completion message
        public string EndMessage()
        {
            return $"Well done! You've finished!";
        }

    }
}
