private static T RandomFrom<T>(IEnumerable<T> source)
{
    // Check if the source is null or empty
    if (source == null || !source.Any())
    {
        throw new ArgumentException("Source collection cannot be null or empty.", nameof(source));
    }

    // Optimize by converting to a list if not already one to avoid multiple enumeration
    var list = source as IList<T> ?? source.ToList();

    // Use a random number generator
    Random rng = new Random();

    // Return a random element from the list
    return list[rng.Next(list.Count)];
}
