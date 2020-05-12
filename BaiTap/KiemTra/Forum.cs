using System;
using System.Collections.Generic;
using System.Text;

namespace KiemTra
{
    class Forum
    {
        public SortedList<int, Post> posts = new SortedList<int, Post>();
        public void Add(int key, Post post)
        {
            posts.Add(key,post);
        }
        public void Update(int key, string content)
        {
            foreach(var keys in posts.Keys)
            {
                if(key == keys)
                {
                    posts[keys].Content = content;
                }    
            }    
        }
        public void Remove(int key)
        {
            posts.Remove(key);
        }
        public void ShowAll()
        {
            foreach(var key in posts.Keys)
            {
                posts[key].Display();
            }    
        }
    }
}
