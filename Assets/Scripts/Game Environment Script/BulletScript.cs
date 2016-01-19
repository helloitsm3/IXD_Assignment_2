using UnityEngine;
public class BulletScript : ProjectileController {
    private int Score;
    protected override void OnCollision(GameObject target)
    {
        EntityScript entity = target.GetComponent<EntityScript>();
        if(entity != null)
        {
            this.controller.OnHit(entity);
        }
    }
}
