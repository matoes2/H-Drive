/**
 * Created by arodriguez on 1/23/2017.
 */
public class Character extends CharacterParent {

    public Character(int Health, int Strength, int Defense){
        health = Health;
        defense = Defense;
        strength = Strength;
    }
    public void TakeDamage(Enemy enemyName){
        int damageTaken = enemyName.strength - defense;
        if(damageTaken < 0){
            damageTaken= 50;
            health -= damageTaken;
        }
        else{
            health -= damageTaken;
        }
    }
    public void Heal(int heal){
        health += heal;
    }
}
