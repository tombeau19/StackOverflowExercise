using System;

namespace StackOverflowExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var post = new Post();
            post.Title = "Hellllpppppp";
            post.Description = "I need help";

            post.DownVote();
            post.DownVote();
            post.DownVote();
            post.DownVote();

            post.UpVote();

            post.DisplayCurrentVotes();
        }
    }
}
