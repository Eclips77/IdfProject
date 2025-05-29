public static class Prompts
{
    public static object GetTerroristRequestObject(int amount)
    {
        string prompt = $@"
Return an array of {amount} unique terrorists in raw valid JSON format ONLY.
Each terrorist should be an object with the following fields:
- name (string): a realistic Arabic male name.
- rank (number): a number between 1 and 5.
- alive (bool): true or false.
- weapons (array of strings): randomly choose 1 to 4 items from this exact list only: ""ak47"", ""handgun"", ""knife"", ""m16"".

IMPORTANT:
- Return ONLY the raw JSON array.
- DO NOT use markdown formatting (no ```).
- DO NOT add any explanation, comments, or extra text.";

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
