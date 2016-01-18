using UnityEngine;
public class BulletScript : ProjectileController {
    private int Score;
    protected override void OnCollision(GameObject target)
    {
        EntityScript entity = target.GetComponent<EntityScript>();
        if(entity != null)
        {
            Score += 10;
            HighscoreScript.currentHighscore.SetScore(Score);
            this.controller.OnHit(entity);
        }
    }
}
