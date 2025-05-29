public static class Prompts
{
    public static object GetTerroristRequestObject(int amount)
    {
        string prompt = $@"Return an array of {amount} unique terrorists in valid JSON format. 
Each terrorist should be an object with the following fields:
- name (string): a realistic Arabic male name.
- rank (int): between 1 and 5.
- alive (bool): true or false.
- location (string): a realistic city or region.

Only return the raw JSON array.
Do not explain, don't use markdown, no extra text.";

        return new
        {
            contents = new[]
            {
                new
                {
                    parts = new[]
                    {
                        new { text = prompt }
                    }
                }
            }
        };
    }
}
