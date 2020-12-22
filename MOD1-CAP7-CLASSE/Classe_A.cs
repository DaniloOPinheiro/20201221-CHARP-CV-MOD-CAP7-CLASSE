namespace MOD1_CAP7_CLASSE
{
    public class Classe_A
    {
        string CNome;

        // Criando o Método Construtor
        public Classe_A (string cn)
        {
            CNome = cn;
        }
        
        //Método Get: Retorna o Valor do Atributo 
         public string getClasse_A ()
         {
             return CNome;
         }
        
        
        public void setClasse_A (string cn)
        {
            CNome = cn;
        }
        
        
    }
}