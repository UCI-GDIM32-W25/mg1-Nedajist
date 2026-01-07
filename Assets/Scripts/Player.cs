using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 1f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5; 
    [SerializeField] private PlantCountUI _plantCountUI;

    private int _numSeedsLeft;
    private int _numSeedsPlanted;

    private void Start ()
    {
        _numSeedsLeft = _numSeeds;
        _numSeedsPlanted = 0;
        _plantCountUI.UpdateSeeds(_numSeedsPlanted, _numSeedsLeft);
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            _playerTransform.Translate(Vector2.left * _speed * 0.005f);
        }

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            _playerTransform.Translate(Vector2.right * _speed * 0.005f);
        }

        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            _playerTransform.Translate(Vector2.up * _speed * 0.005f);
        }

        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            _playerTransform.Translate(Vector2.down * _speed * 0.005f);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlantSeed();
        }
    }

    public void PlantSeed ()
    {
        if (_numSeedsLeft > 0)
        {
            _numSeedsLeft -= 1;
            _numSeedsPlanted += 1;
            _plantCountUI.UpdateSeeds(_numSeedsPlanted, _numSeedsLeft);

            GameObject _plant = Instantiate(_plantPrefab);
            _plant.transform.position = _playerTransform.position;
        }
    }
}
