﻿// ---------------------------------------------------------------------------------------------------------------------
// Imports
// ---------------------------------------------------------------------------------------------------------------------
using AterraEngine.Unions;
using System.Diagnostics.CodeAnalysis;

namespace InfiniLore.Database.RepositoryPattern;

// ---------------------------------------------------------------------------------------------------------------------
// Code
// ---------------------------------------------------------------------------------------------------------------------
[UnionAliases("Success", "Failure")]
public readonly partial struct RepoResult() : IUnion<Success, Failure<string>> {
    public static implicit operator RepoResult(string input) => new Failure<string>(input);
    public static implicit operator RepoResult(bool value) => value ? new Success() : new Failure<string>();

    public static implicit operator bool(RepoResult value) => value.IsSuccess;
}

[UnionAliases("Success", "Failure")]
public readonly partial struct RepoResult<T>() : IUnion<Success<T>, Failure<string>> {
    public bool TryGetSuccessValue([NotNullWhen(true)] out T? value) {
        if (IsSuccess) {
            value = AsSuccess.Value;
            return value is not null;
        }

        value = default;
        return false;
    }

    public static implicit operator RepoResult<T>(string input) => new Failure<string>(input);
    public static implicit operator RepoResult<T>(T value) => new Success<T>(value);

    public static implicit operator bool(RepoResult<T> value) => value.IsSuccess;

    public SuccessOrFailure<T> ToSuccessOrFailure() {
        if (IsSuccess) return AsSuccess;

        return AsFailure;
    }
}