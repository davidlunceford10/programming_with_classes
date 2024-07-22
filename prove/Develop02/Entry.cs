public class Entry
    {
        //Here in entry we have the constructor for a basic entry 
        public string _date { get; set; }
        public string _prompt { get; set; }
        public string _response { get; set; }

        public Entry(string date, string prompt, string response)
        {
            _date = date;
            _prompt = prompt;
            _response = response;
        }
    }