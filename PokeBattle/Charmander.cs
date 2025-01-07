namespace PokeBattle
{
    public class Charmander
    {
        public string nickname;
        public string strength = "fire";
        public string weakness = "water";

        public Charmander(string nickname)
        {
            this.nickname = nickname;
        }

        public void BattleCry()
        {
            Console.WriteLine($"{nickname}: HAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
        }

        public string GetNickname()
        {
            return nickname;
        }

        public void SetNickname(string nickname)
        {
            this.nickname = nickname;
        }
    }
}