using System;

namespace StackOverflowExercise
{
    public class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; private set; }
        public int UpVotes { get; private set; }
        public int DownVotes { get; private set; }


        public void UpVote()
        {
            UpVotes += 1;
            Console.WriteLine($"Yay! a vote for you. Total Up Votes {UpVotes}");
        }

        public void DownVote()
        {
            DownVotes += 1;
            Console.WriteLine($"Oh no! No bueno. Total Down Votes {DownVotes}");
        }

        public void DisplayCurrentVotes()
        {
            Console.WriteLine($"Post \"{Title}\" has {DownVotes} down votes and {UpVotes} up votes");
        }

        public Post()
        {
            CreatedDate = DateTime.Now;
            Console.WriteLine($"Created a Post at {CreatedDate}");
        }
    }
}