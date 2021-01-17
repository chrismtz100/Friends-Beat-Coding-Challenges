
public class NeedleInHaystack {
    public int StrStr(string haystack, string needle) {
        if (needle.Length == 0) {
            return 0;
        }
        
        int counter = 0;
        int start = 0;
        for (int i = 0; i < haystack.Length; i++) {
            if (needle[counter] == haystack[i]) {
                start = i;
                while (true) {
                    //found a term, go to the next one.
                    if (counter >= haystack.Length || start >= haystack.Length) {
                        break;
                    }
                    else if (needle[counter] == haystack[start]) { 
                        counter++;
                        start++;
                        //if counter is equal to the length of haystack, END
                        if (counter == needle.Length) { 
                            return i;
                        }
                    }
                    //not found, reset and continue
                    else { 
                        counter = 0;
                        start = 0;
                        break;
                    }
                }
            }
        }
        return - 1;
    }
    public static void main(String[] args) {
        Console.WriteLine("Hello!");
    }
}