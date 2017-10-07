using UnityEngine;
using System.Collections;

public class circle : MonoBehaviour
{

	public float theta_scale = 0.1f;             //Set lower to add more points

	public float angle;
	int size;
	public float r, n = 0;
	private float radius;
	float kkize;
	public float a, b;

	LineRenderer lineRenderer;
	void OnEnable()
	{
		if (gameObject.CompareTag("p1"))
			angle = 0;

	}
	void Start()
	{
		lineRenderer = gameObject.GetComponent<LineRenderer>();
		//lineRenderer.material = new Material (Shader.Find ("Particles/Additive"));
		lineRenderer.SetColors(Color.blue, Color.green);
		//lineRenderer.SetWidth (0.2F, 0.2F);
		float kize = angle / theta_scale;
		size = (int)kize;

		lineRenderer.SetVertexCount(size);
		radius = r;
	}
	void LateUpdate()
	{
		float kize = angle / theta_scale;


		if (gameObject.CompareTag("c"))
		{
			if (kize != size || radius != r)
			{
				size = (int)kize;
				radius = r;
				a = r - n;
				b = r + n;
				lineRenderer.SetVertexCount(size);
				int i = 0;

				for (float theta = 0; theta < angle; theta += theta_scale)
				{
					float x = a * Mathf.Cos(theta);
					float y = b * Mathf.Sin(theta);

					Vector3 pos = new Vector3(x, y, 0) + gameObject.transform.position;
					if (i < size)
						lineRenderer.SetPosition(i, pos);
					i += 1;
				}
			}


		}
		if (kize != kkize || radius != r)
		{
			size = (int)kize;
			radius = r;

			lineRenderer.SetVertexCount(size);
			int i = 0;

			for (float theta = 0; theta < angle; theta += theta_scale)
			{
				float x = r * Mathf.Cos(theta);
				float y = r * Mathf.Sin(theta);

				Vector3 pos = new Vector3(x, y, 0) + gameObject.transform.position;
				if (i < size)
					lineRenderer.SetPosition(i, pos);
				i += 1;
			}
		}
		kkize = kize;



	}


}


