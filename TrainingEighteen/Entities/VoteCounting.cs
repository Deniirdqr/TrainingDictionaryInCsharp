using System;

namespace TrainingEighteen.Entities
{
    class VoteCounting
    {
        public string Candidate { get; set; }
        public int Votes { get; set; }

        public override int GetHashCode()
        {
            return Candidate.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if(!(obj is VoteCounting))
            {
                return false;
            }
            VoteCounting other = obj as VoteCounting;
            return Candidate.Equals(other.Candidate);
        }
    }
}
