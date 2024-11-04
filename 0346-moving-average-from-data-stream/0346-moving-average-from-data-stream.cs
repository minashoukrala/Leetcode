public class MovingAverage {

    Queue<int> window;
    int windowSize;
    int sum;

    public MovingAverage(int size) {
        this.windowSize = size;
        this.window = new Queue<int>();
        this.sum = 0;
        
    }
    
    public double Next(int val) {
        if(window.Count == windowSize) { sum -= window.Dequeue(); }
        window.Enqueue(val);
        sum += val;

        return (double)sum/window.Count();

        
    }
}

/**
 * Your MovingAverage object will be instantiated and called as such:
 * MovingAverage obj = new MovingAverage(size);
 * double param_1 = obj.Next(val);
 */