namespace Basic_Notes.Contracts;

public record CreateNoteRequest(
    string Title,
    string Description
);