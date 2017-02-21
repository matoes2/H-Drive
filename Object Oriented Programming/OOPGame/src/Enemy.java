/**
 * Created by arodriguez on 1/23/2017.
 */
public class Enemy extends CharacterParent {
    public String enemyName;
    Enemy(int Health, int Strength, int Defense, String Name) {
        health = Health;
        strength = Strength;
        defense = Defense;
        enemyName = Name;
    }
    public void TakeDamage(Character characterName) {
        int damageTaken = characterName.strength - defense;
        if(damageTaken <= 0){
            damageTaken = 1;
            health -= damageTaken;
        }
        else {
            health -= damageTaken;
        }
    }
}
