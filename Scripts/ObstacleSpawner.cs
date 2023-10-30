using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private Vector2 _spawnPosition;
    [SerializeField] private GameObject[] _currentObstacles, _obstaclesEasy,_obstaclesMedium, _obstaclesHard;
    [SerializeField] private int _difficultyIncreasingValue, _difficultyLimit;
    private int _iterator = 0;
    private List<GameObject[]> _allDifficultyObstacles = new List<GameObject[]>();
    private int _currentDifficulty = 0;
    private void Start()
    {
        _allDifficultyObstacles.Add(_obstaclesEasy);
        _allDifficultyObstacles.Add(_obstaclesMedium);
        _allDifficultyObstacles.Add(_obstaclesHard);
        _currentObstacles = _obstaclesEasy;
    }
    public void StartSpawning() => StartCoroutine(ISpawnRoutine());
    private IEnumerator ISpawnRoutine()
    {
        while (true)
        {
            Instantiate(_currentObstacles[Random.Range(0, _currentObstacles.Length)], _spawnPosition, Quaternion.identity);
            _iterator+=2;
            yield return new WaitForSeconds(2f);
            if (_iterator % _difficultyIncreasingValue == 0 && _currentDifficulty + 1 < _difficultyLimit)
            {
                _currentDifficulty++;
                _currentObstacles = _allDifficultyObstacles[_currentDifficulty];
            }
        }
    }
}