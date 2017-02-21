/**
 * Created by arodriguez on 1/23/2017.
 */
import java.util.*;
public class OOPGame {
    public static long xp;
    public static void main(String[] args){
        Scanner sc = new Scanner(System.in);
        Character player = new Character(1000, 20, 10);
        player.level = 1;
        Random rand = new Random();
        Area area;
        ArrayList<String> promptList = new ArrayList<String>();
        promptList.add("You found a rusty sword but decided not to pick it up because you can not remember if you had your tetnus shot.");
        promptList.add("You found a spoon and decided to discard your current weapon for the spoon because cool people fight with spoons");
        promptList.add("Look, a snake Pit filled with Snakes!  Looks like a good place to lay down for a nap.");
        promptList.add("A dragonfly flies by your head. You recall, you once heard that dragons taste like chicken, and you wonder if dragonflies get their name because they too taste like chicken.  You decide you can no longer live with this mystery and go and catch the dragonfly.  As you eat the dragonfly you realize that they do not taste like chicken, this leads you to wonder if dragons really do taste like chicken.  As you ponder this idea you realize that they might not taste like chicken as you assumed. You procede to wonder if it is possible that everything else you assumed was true about the world could also be false.  You continue to be lost in your own thoughts not paying attention to your surroundings when a ladybug flies up your nose.");
        area = new JungleArea();
        while(true){
            int randNum = rand.nextInt(4);
            if(randNum < 3) {
                Enemy enemy = area.EnemyEncounter();
                System.out.println("\n");
                System.out.println("You have encountered a " + enemy.enemyName);
                while (enemy.health > 0) {
                    if(player.health <= 200){
                        player.Heal(500);
                    }
                    System.out.println("Your health is: " + player.health + "\nEnemy's health is: " + enemy.health);
                    enemy.TakeDamage(player);
                    player.TakeDamage(enemy);
                    if (player.health <= 0) {
                        System.out.println("You have taken a huge hit and have died...\nWould you like to continue?(y/n)");
                        String choice = sc.nextLine();
                        if (choice.equals("y")) {
                            player.health = 1000;
                            System.out.println("You have absorbed the soul of the " + enemy.enemyName + " and have respawned.\nYour health is now: " + player.health);
                            break;
                        } else {
                            return;
                        }
                    }
                    if (enemy.health <= 0) {
                        int gainedXp = rand.nextInt(10);
                        xp += gainedXp;
                        System.out.println("You killed the " + enemy.enemyName + " you received " + gainedXp + " xp, your current xp is: " + xp + " your level is: " + player.level + ".");
                        try{
                            Thread.sleep(5000);
                        }
                        catch(InterruptedException ex){
                            Thread.currentThread().interrupt();
                        }
                        if (xp > 100 * player.level) {
                            player.level += 1;
                            System.out.println("Your level is now: " + player.level);
                            int areaNum = rand.nextInt(4);
                            if (areaNum == 0) {
                                area = new PlainsArea();
                                break;
                            } else if (areaNum == 1) {
                                area = new FrostArea();
                                break;
                            } else if (areaNum == 2) {
                                area = new DesertArea();
                                break;
                            } else if (areaNum == 3) {
                                area = new JungleArea();
                                break;
                            }
                        }
                    }
                }
            }
            else{
                int promptRand = rand.nextInt(promptList.size());
                System.out.println(promptList.get(promptRand));
            }
        }
    }
}
