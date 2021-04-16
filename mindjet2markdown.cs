//Very basic conversion for Mindjet Mindmap (PC v14) text outline export to a Markdown file
//This is based on the Ruby gist at: https://gist.github.com/ttscoff/6308043

//Set vars here or supply vars
string inputTextFile = @"C:\mindjet_map.txt";
string outputMdFile = @"C:\mindjet_map.md";

//Read file
string str = System.IO.File.ReadAllText(inputTextFile);

//Perform topic conversions
str = Regex.Replace(str, @"^=+\n ?(.*?)\n=+/", "# $1", RegexOptions.Multiline);
str = Regex.Replace(str, @"^-+\n[0-9]+ (.*?)\n-+", "## $1", RegexOptions.Multiline);
str = Regex.Replace(str, @"^[0-9]+\.[0-9]+ (.*)", "### $1", RegexOptions.Multiline);
str = Regex.Replace(str, @"^\d+\.\d+\.\d+\s", "#### ", RegexOptions.Multiline);
str = Regex.Replace(str, @"^\d+\.\d+\.\d+\.\d+\s", "##### ", RegexOptions.Multiline);
str = Regex.Replace(str, @"^\d\s", "", RegexOptions.Multiline);

//Replace links
str = Regex.Replace(str, @"(?<Protocol>\w+):\/\/(?<Domain>[\w@][\w.:@]+)\/?[\w\.?=%&=\-@/$,]*", "[$0]($0)", RegexOptions.Multiline & RegexOptions.IgnoreCase);

//Double enter at end of lines ending with period (.), question mark (?) or exclamation (!)
str = Regex.Replace(str, @"(\.|\?|\!)[\r\n]", "$1\r\n\r\n", RegexOptions.Multiline & RegexOptions.IgnoreCase);

//Example if  you wanted to copy the results to clipboard to paste into a Markdown editor
//System.Windows.Forms.Clipboard.SetText(str);

//Export file
System.IO.File.WriteAllText(outputMdFile, str);

//Output it to the screen for fun
Console.WriteLine(str);
