using BNG;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.AI;
using static UnityEngine.GraphicsBuffer;

public class EliteMonster : Monster
{
    public MonsterBullet monsterBullet;

    [Header("몬스터 원거리 관련")]
    public Transform bulletPortLeft;
    public Transform bulletPortRight;
    public Transform bulletPort;
    public GameObject monsterBulletPrefab;

    public override IEnumerator MonsterAction()
    {
        while (!isDie)
        {
            switch (state)
            {
                // IDLE 상태 =======================================================
                case State.IDLE:
                    //GFunc.Log("IDLE state");
                    nav.isStopped = true;
                    anim.SetBool(hashRun, false);
                    anim.SetBool(hashidle, true);
                    //anim.SetBool(hashWalkingAttack, false);
                    anim.SetBool(hashAttack, false);
                    anim.SetBool(hashAttack2, false);
                    anim.SetBool(hashAttack3, false);
                    anim.SetBool(hashAttack4, false);
                    break;

                // TRACE 상태 =======================================================
                case State.TRACE:
                    //GFunc.Log("TRACE state");
                    nav.isStopped = false;
                    nav.SetDestination(playerTr.position);
                    anim.SetBool(hashRun, true);
                    anim.SetBool(hashWalkingAttack, false);
                    anim.SetBool(hashAttackRuning, true);
                    anim.SetBool(hashAttackRuning2, true);
                    anim.SetBool(hashAttackRuning3, true);
                    break;

                // ATTACK 상태 =======================================================
                case State.ATTACK:

                    //GFunc.Log("ATTACK state");

                    switch (monsterType)
                    {
                        case Type.HUMAN_ROBOTRED:

                            int humanRobotRed = Random.Range(0, 2);

                            switch (humanRobotRed)
                            {
                                case 0:
                                    anim.SetBool(hashWalkingAttack, true);
                                    anim.SetBool(hashAttack, true);
                                    yield return new WaitForSeconds(1.3f);
                                    anim.SetBool(hashidle, true);
                                    anim.SetBool(hashAttack, false);
                                    anim.SetBool(hashWalkingAttack, false);
                                    anim.SetBool(hashRun, false);
                                    yield return new WaitForSeconds(attDelay);
                                    break;

                                case 1:
                                    //anim.SetBool(hashWalkingAttack, true);
                                    anim.SetBool(hashAttack2, true);

                                    yield return new WaitForSeconds(1.3f);
                                    anim.SetBool(hashidle, true);
                                    anim.SetBool(hashAttack2, false);
                                    //anim.SetBool(hashWalkingAttack, false);
                                    anim.SetBool(hashRun, false);
                                    yield return new WaitForSeconds(attDelay);
                                    break;

                            }
                            break;

                        case Type.HUMAN_GOLEMFIRE:

                            int humanGolemFire = Random.Range(0, 3);

                            switch (humanGolemFire)
                            {
                                case 0:
                                    anim.SetBool(hashWalkingAttack, true);
                                    anim.SetBool(hashAttack, true);
                                    yield return new WaitForSeconds(1.3f);
                                    anim.SetBool(hashidle, true);
                                    anim.SetBool(hashAttack, false);
                                    anim.SetBool(hashWalkingAttack, false);
                                    anim.SetBool(hashRun, false);
                                    yield return new WaitForSeconds(attDelay);
                                    break;

                                case 1:
                                    //anim.SetBool(hashWalkingAttack, true);
                                    anim.SetBool(hashAttack2, true);

                                    yield return new WaitForSeconds(1.3f);
                                    anim.SetBool(hashidle, true);
                                    anim.SetBool(hashAttack2, false);
                                    //anim.SetBool(hashWalkingAttack, false);
                                    anim.SetBool(hashRun, false);
                                    yield return new WaitForSeconds(attDelay);
                                    break;

                                case 2:
                                    //anim.SetBool(hashWalkingAttack, true);
                                    anim.SetBool(hashAttack3, true);
                                    yield return new WaitForSeconds(1.2f);
                                    anim.SetBool(hashidle, true);
                                    anim.SetBool(hashAttack3, false);
                                    //anim.SetBool(hashWalkingAttack, false);
                                    anim.SetBool(hashRun, false);
                                    yield return new WaitForSeconds(attDelay);
                                    break;

                            }
                            break;

                        case Type.BEAST_SCORPION:

                            int spider = Random.Range(0, 3);

                            switch (spider)
                            {
                                case 0:
                                    anim.SetBool(hashWalkingAttack, true);
                                    anim.SetBool(hashAttack, true);
                                    yield return new WaitForSeconds(0.8f);
                                    anim.SetBool(hashidle, true);
                                    anim.SetBool(hashAttack, false);
                                    //anim.SetBool(hashWalkingAttack, false);
                                    anim.SetBool(hashRun, false);
                                    yield return new WaitForSeconds(attDelay);
                                    break;

                                case 1:
                                    anim.SetBool(hashAttack2, true);
                                    yield return new WaitForSeconds(0.8f);
                                    anim.SetBool(hashidle, true);
                                    anim.SetBool(hashAttack2, false);
                                    //anim.SetBool(hashWalkingAttack, false);
                                    anim.SetBool(hashRun, false);
                                    yield return new WaitForSeconds(attDelay);
                                    break;

                                case 2:
                                    anim.SetBool(hashAttack3, true);
                                    yield return new WaitForSeconds(0.8f);
                                    anim.SetBool(hashidle, true);
                                    anim.SetBool(hashAttack3, false);
                                    //anim.SetBool(hashWalkingAttack, false);
                                    anim.SetBool(hashRun, false);
                                    yield return new WaitForSeconds(attDelay);
                                    break;

                            }
                            break;

                        case Type.BEAST_QUEENWORM:

                                case 0:
                                    anim.SetBool(hashWalkingAttack, true);
                                    anim.SetBool(hashAttack, true);
                                    yield return new WaitForSeconds(0.8f);
                                    anim.SetBool(hashidle, true);
                                    anim.SetBool(hashAttack, false);
                                    //anim.SetBool(hashWalkingAttack, false);
                                    anim.SetBool(hashRun, false);
                                    yield return new WaitForSeconds(attDelay);
                                    break;

                        case Type.SIMPLE_TOADSTOOL:

                            int toadStool = Random.Range(0, 3);

                            switch (toadStool)
                            {
                                case 0:
                                    anim.SetBool(hashWalkingAttack, true);
                                    anim.SetBool(hashAttack, true);
                                
                                    yield return new WaitForSeconds(0.2f);
                                    anim.SetBool(hashidle, true);
                                    anim.SetBool(hashAttack, false);
                                    anim.SetBool(hashWalkingAttack, false);
                                    anim.SetBool(hashRun, false);
                                    yield return new WaitForSeconds(attDelay);
                                    break;

                                case 1:
                                    anim.SetBool(hashAttack2, true);
                                    
                                    yield return new WaitForSeconds(0.2f);
                                    anim.SetBool(hashidle, true);
                                    anim.SetBool(hashAttack2, false);
                                    //anim.SetBool(hashWalkingAttack, false);
                                    anim.SetBool(hashRun, false);
                                    yield return new WaitForSeconds(attDelay);
                                    break;

                                case 2:
                                    anim.SetBool(hashAttack3, true);

                                    yield return new WaitForSeconds(0.7f);
                                    anim.SetBool(hashidle, true);
                                    anim.SetBool(hashAttack3, false);
                                    //anim.SetBool(hashWalkingAttack, false);
                                    anim.SetBool(hashRun, false);
                                    yield return new WaitForSeconds(attDelay);
                                    break;
                            }
                            break;

                        case Type.SIMPLE_PHANTOM:

                            int phantom = Random.Range(0, 3);

                            switch (phantom)
                            {
                                case 0:
                                    anim.SetBool(hashWalkingAttack, true);
                                    anim.SetBool(hashAttack, true);

                                    yield return new WaitForSeconds(1.0f);
                                    anim.SetBool(hashidle, true);
                                    anim.SetBool(hashAttack, false);
                                    //anim.SetBool(hashWalkingAttack, false);
                                    //anim.SetBool(hashRun, false);
                                    yield return new WaitForSeconds(attDelay);
                                    break;

                                case 1:
                                    anim.SetBool(hashAttack2, true);

                                    yield return new WaitForSeconds(1.0f);
                                    anim.SetBool(hashidle, true);
                                    anim.SetBool(hashAttack2, false);
                                    //anim.SetBool(hashWalkingAttack, false);
                                    //anim.SetBool(hashRun, false);
                                    yield return new WaitForSeconds(attDelay);
                                    break;

                                case 2:
                                    anim.SetBool(hashAttack3, true);

                                    yield return new WaitForSeconds(1.0f);
                                    anim.SetBool(hashidle, true);
                                    anim.SetBool(hashAttack3, false);
                                    //anim.SetBool(hashWalkingAttack, false);
                                    anim.SetBool(hashRun, false);
                                    yield return new WaitForSeconds(attDelay);
                                    break;
                            }
                            break;
                    }
                    break;


                case State.DIE:
                    isDie = true;
                    nav.isStopped = true;
                    //GFunc.Log("nav.isStopped: " + nav.isStopped);
                    anim.SetTrigger(hashDie);
                    Invoke(nameof(MonsterDestroy), 3.0f);
                    foreach (CapsuleCollider capsuleCollider in capsuleColliders)
                    {
                        capsuleCollider.isTrigger = true;
                    }
                    UserData.KillElite(exp);
                    //Destroy(this.gameObject, 1.3f); //damageable 쪽에서 처리
                    yield break;
            }

            yield return new WaitForSeconds(0.1f);
        }


    }

    public void MonsterDestroy()
    {
        Destroy(this.gameObject);
    }

    

    public void GolemShoot(int index)
    {
        switch(index)
        {
            case 0:
                GameObject instantBulletLeft = Instantiate(monsterBulletPrefab, bulletPortLeft.position, bulletPortLeft.rotation);
                //MonsterBullet bulletLeft = instantBulletLeft.GetComponent<MonsterBullet>();
                bulletPortRight.transform.LookAt(playerTr.position);
                //instantBulletLeft.transform.LookAt(playerTr);

                GameObject instantBulletRight = Instantiate(monsterBulletPrefab, bulletPortRight.position, bulletPortLeft.rotation);
                //MonsterBullet bulletRight = instantBulletRight.GetComponent<MonsterBullet>();
                bulletPortRight.transform.LookAt(playerTr.position);
                //instantBulletRight.transform.LookAt(playerTr);
                break;
        }
    }

    public void Shoot(int index)
    {
        switch(index)
        {
            case 0:
                GameObject instantBullet = Instantiate(monsterBulletPrefab, bulletPort.position, bulletPort.rotation);
                MonsterBullet bullet = instantBullet.GetComponent<MonsterBullet>();
                bulletPort.transform.LookAt(playerTr.position);
                //instantBullet.transform.LookAt(playerTr);
                break;

                case 1:
                GameObject instantBulletRight = Instantiate(monsterBulletPrefab, bulletPortRight.position, bulletPortRight.rotation);
                MonsterBullet bulletRight = instantBulletRight.GetComponent<MonsterBullet>();
                bulletPortRight.transform.LookAt(playerTr.position);
                //instantBulletRight.transform.LookAt(playerTr);
                break;

                case 2:
                GameObject instantBulletLeft = Instantiate(monsterBulletPrefab, bulletPortLeft.position, bulletPortLeft.rotation);
                MonsterBullet bulletLeft = instantBulletLeft.GetComponent<MonsterBullet>();
                bulletPortRight.transform.LookAt(playerTr.position);
                //instantBulletLeft.transform.LookAt(playerTr);
                break;
        }
    }

   
}
