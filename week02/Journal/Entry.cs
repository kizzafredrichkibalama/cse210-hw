using System;

public class Entry
{
    // Member variables to store the entry data
    private string _prompt;
    private string _response;
    private string _date;

    // Constructor - initializes an entry with a prompt, response, and date
    public Entry(string prompt, string response, string date)
    {
        _prompt = prompt;
        _response = response;
        _date = date;
    }

    // Getter methods to access the private member variables
    public string GetPrompt()
    {
        return _prompt;
    }

    public string GetResponse()
    {
        return _response;
    }

    public string GetDate()
    {
        return _date;
    }

    // ToString method - makes it easy to display an entry nicely
    public override string ToString()
    {
        return $"Date: {_date}\nPrompt: {_prompt}\nResponse: {_response}\n";
    }

    // SaveToString - formats entry data for saving to a file
    // Uses ~|~ as a separator (unlikely to appear in normal text)
    public string SaveToString()
    {
        return $"{_date}~|~{_prompt}~|~{_response}";
    }
}
