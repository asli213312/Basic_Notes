namespace Basic_Notes.Contracts;

public record GetNotesRequest(string? Search, string? SortItem, string? SortOrder);