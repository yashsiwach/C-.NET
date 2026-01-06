public class Solution {
    public bool IsValid(string s) {
        Stack<char>st=new Stack<char>();
      
        for(int i=0;i<s.Length;i++){
            if(st.Count()==0){
                st.Push(s[i]);
                continue;
            }
            char ch=st.Peek();
            if(s[i]==')'&&ch=='('){
                st.Pop();
            }
            else if(s[i]=='}'&&ch=='{'){
                st.Pop();
            }
            else if(s[i]==']'&&ch=='['){
                st.Pop();
            }
            else if(s[i]==')'||s[i]=='}'||s[i]==']'){
                return false;
            }
            
            if(s[i]=='('||s[i]=='{'||s[i]=='['){
                st.Push(s[i]);
            }
            
        }
        return st.Count==0;
    }
}