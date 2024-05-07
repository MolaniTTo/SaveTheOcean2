using System;


namespace SaveTheOcean2.DTO
{
    public class Player
    {
        public string Name {  get; set; }
        public string? Rol {  get; set; }
        public int Xp { get; set; }
        
        public Player(string name, string rol)
        {
            this.Name = name;
            this.Rol = rol;
            if (Rol == "Veterinarian")
            {
                this.Xp = 80;
            }
            else
            {
                this.Xp = 45;
            }
            
        }
        

    }
}
