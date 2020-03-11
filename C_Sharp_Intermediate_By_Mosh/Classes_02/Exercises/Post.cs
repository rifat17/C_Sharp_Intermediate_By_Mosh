using System;
namespace C_Sharp_Intermediate_By_Mosh.Classes_02.Exercises
{
    public class Post
    {
        public string Title { get; private set; }
        public string Description { get; private set; }
        public DateTime CreatedAt { get; }
        private int _upVote;
        private int _downVote;

        public Post(string title, string description)
        {
            Title = title;
            Description = description;

            CreatedAt = DateTime.Now;
            _upVote = 0;
            _downVote = 0;
        }

        public void UpVote()
        {
            _upVote += 1;
        }

        public void DownVote()
        {
            _downVote += 1;
        }

        public void CurrentVote()
        {
            Console.WriteLine("UpVote : {0} | DownVote : {1}", _upVote, _downVote);
        }


    }
}
