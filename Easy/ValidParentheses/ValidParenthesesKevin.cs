public class Solution {
    
    Stack<char> Brackets = new Stack<char>();
    
    public bool IsValid(string s) {
        char[] cArr = s.ToCharArray();
      
      	var map = new Dict<char,char>(){{'{','}'},{'[',']'},{'(',')'}};

      	foreach(var c in cArr){
          
          	if(c == '{' || c == '['  || c == '(' ){
              Brackets.push(map[c]);
            }
          	else if((c == '}' || c == '}'  || c == '}') && !TryPop(Bracket.Curly)){
              return false;
            }
            else{
               return false;
            }
        }
        return true;
    }
        
    // returns a boolean to check if bracket is poppable
    public bool TryPop(char b){
        
        if(Brackets.Peek() == b){
            Brackets.Pop();
            return true;
        }
        return false;
    }
}

