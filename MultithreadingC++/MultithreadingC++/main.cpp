#include <iostream>
#include <sstream>
#include <iomanip>
#include <thread>
#include <vector>
#include <Windows.h>
#include <time.h>

/*
 @Author Calvin Truong
 @Version 1.0
*/

using namespace std;

void displayCommand();
void createThreads(int numThreads, int maxSeconds);
void countingThread(int counter);

volatile int counters[6];
volatile int threadTurn;
volatile bool requiresUpdate;
volatile bool endThreads;

CRITICAL_SECTION cs;

int main() {

	do {
		displayCommand();
	} while (true);

	cin.get();

	return 0;
}

/*
 *@Description: Creates a specified number of threads
 that will run for a specified number of seconds

 Once the number of seconds has elapsed, the threads will terminate.
 */
void createThreads(int numThreads, int maxSeconds) {
	const int width = 15;
	vector<thread*> threads;
	clock_t timer = 0;
	clock_t initTime = 0;
	requiresUpdate = true;
	endThreads = false;

	EnterCriticalSection(&cs);
	for (int i = 0; i < numThreads; i++) {
		counters[i] = 0;
		thread* temp = new thread(countingThread, i);
		threads.push_back(temp);
	}
	LeaveCriticalSection(&cs);

	initTime = clock();

	threadTurn = numThreads;

	do {

		if (requiresUpdate && threadTurn == numThreads) {

			EnterCriticalSection(&cs);

			for (int i = 0; i < numThreads; i++) {

				cout << setw(width) << "Thread #" << i << ": " << counters[i];

				if (i == (numThreads - 1))
					cout << "\n";

			}

			requiresUpdate = false;

			threadTurn = 0;
			LeaveCriticalSection(&cs);
		}

		timer = clock() - initTime;

		timer = timer / CLOCKS_PER_SEC;

		if (timer > maxSeconds)
			endThreads = true;

	} while (!endThreads);

	cout << maxSeconds << " seconds has passed\n";
}

void countingThread(int counter) {
	do
	{
		if (threadTurn == counter) {
			EnterCriticalSection(&cs);
			counters[counter]++;
			requiresUpdate = true;
			threadTurn++;
			LeaveCriticalSection(&cs);
		}
	} while (!endThreads);
}

/*
	@Description: Prompts user for the following:
	- The number of threads to execute
	- The number of seconds to run for
	Once the prompt receives the necessary input from the user, it executes the
	createThreads function
*/
void displayCommand() {
	string str;
	InitializeCriticalSection(&cs);
	int numThreads = -1;
	int maxSeconds = -1;

	std::cout << "How many threads do you want to make? (Max 6) \n: ";

	do {
		getline(cin, str);
		istringstream iss(str);

		if (!(iss >> numThreads)) {
			cout << "Invalid Input for # of Threads, please try again\n: ";
		}
		else if (numThreads < 0 || numThreads > 6) {
			numThreads = -1;

			cout << "Invalid # of threads must be between 1~6, please try again\n: ";
		}
	} while (numThreads == -1);

	cout << "Enter the number of seconds (1 ~ 90): ";

	do {
		getline(cin, str);
		istringstream iss(str);

		if (!(iss >> maxSeconds)) {
			cout << "Invalid Input for number of seconds, please try again\n: ";
		}
		else if (maxSeconds < 0 || maxSeconds > 90) {
			maxSeconds = -1;

			cout << "Invalid number for seconds must be between 1~90, please try again\n: ";
		}
	} while (maxSeconds == -1);

	createThreads(numThreads, maxSeconds);
}