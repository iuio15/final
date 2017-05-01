function OnCollisionEnter(theCollision : Collision){
   if(theCollision.gameObject.tag=="Enemy") {
     Destroy(gameObject);
   }
}