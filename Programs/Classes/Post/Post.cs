using System;

namespace StackOverflowPost
{
    class Post
    {
        public string Title {get; set;}
        public string Description {get; set;}
        public DateTime CreateDate {get; set;}

        private int like = 0;
        private int dislike = 0;

        public Post()
        {
            
        }
        public void CreatePost(string title, string desc, DateTime date)
        {
            this.Title = title;
            this.Description = desc;
            this.CreateDate = date;
        }

        public string ShowVotes()
        {
            return "Votes are " + like.ToString() + "Likes," + dislike.ToString() + " Dislikes" ;
        }

        public string ShowPost()
        {
            return "Title: " + Title + "\nDescription: " + Description + "\nCreated Date: " + CreateDate + "\nLikes: " + like.ToString() + "\nDislike: " + dislike.ToString();
        }

        public int UpVote()
        {
            like++;
            return like;
        }

        public int DownVote()
        {
            dislike++;
            return dislike;
        }

    
    }
}
