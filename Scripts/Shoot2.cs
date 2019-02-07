using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Shoot2 : MonoBehaviour
{
	[SerializeField]
	float pullSpeed;
	[SerializeField]
	GameObject arrowPrefab;
	[SerializeField]
	GameObject arrow;
	[SerializeField]
	GameObject bow;
	[SerializeField]
	int numberOfArrows = 10;
	bool arrowSlotted = false;
	float pullAmount = 0;
	public Rigidbody _arrowRigidB;
	//Rigidbody _arrowRigidB = arrow.transform.GetComponent<Rigidbody>;

	// Use this for initialization
	void Start()
	{
		SpawnArrow();
	}

	// Update is called once per frame
	void Update()
	{
		ShootLogic ();
	}

	void SpawnArrow()
	{
		if (numberOfArrows > 0)
		{
			arrowSlotted = true;
			arrow = Instantiate(arrowPrefab, transform.position, transform.rotation) as GameObject;
			arrow.transform.parent = transform;
		}
	}

	void ShootLogic()
	{
		if (numberOfArrows > 0)
		{
			if (pullAmount > 100)
				pullAmount = 100;

			SkinnedMeshRenderer _bowSkin = bow.transform.GetComponent<SkinnedMeshRenderer>();
			SkinnedMeshRenderer _arrowSkin = arrow.transform.GetComponent<SkinnedMeshRenderer>();
			_arrowRigidB = arrow.transform.GetComponent<Rigidbody> ();
			//Rigidbody _arrowRigidB = arrow.transform.GetComponent<Rigidbody> ();
			//ProjectileAddForce _arrowProjectile = arrow.transform.GetComponent<ProjectileAddForce>();
			if (Input.GetMouseButton(0)) {
				pullAmount += Time.deltaTime * pullSpeed;

			}
			if (Input.GetMouseButtonUp (0)){

				arrowSlotted = false;
				_arrowRigidB.isKinematic = false;
				arrow.transform.parent = null;
				_arrowRigidB.AddForce (transform.forward * 600f);
				_arrowRigidB.useGravity = true;
				//_arrowProjectile.shootForce = _arrowProjectile.shootForce * ((pullAmount / 100) + .05f);
				numberOfArrows -= 1;
				pullAmount = 0;

				//_arrowProjectile.enabled= true;
			}
			_bowSkin.SetBlendShapeWeight (0, pullAmount);
			_arrowSkin.SetBlendShapeWeight (0, pullAmount);

			if (Input.GetMouseButtonDown (0) && arrowSlotted == false)
				SpawnArrow ();
		}
	}
}